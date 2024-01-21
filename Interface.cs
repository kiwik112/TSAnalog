using SharpDX.DirectInput;
using System.Diagnostics;

namespace TSAnalog
{
    internal class Interface
    {
        public static bool running = false;

        public static List<Device> ActiveDevices = new List<Device>();
        public static List<Joystick> GetActiveJoysticks()
        {
            List<Joystick> joysticks = new List<Joystick>();
            foreach (Device device in ActiveDevices)
            {
                joysticks.Add(device.joystick);
            }
            return joysticks;
        }

        public static void StartJoyThread(int deviceIndex)
        {
			Debug.WriteLine("Starting");
            Thread thread = new Thread(() => joyThread(deviceIndex));
			thread.Start();
        }

        private static void joyThread(int deviceIndex)
        {
			Debug.WriteLine("Started");
            Device device = ActiveDevices[deviceIndex];
            while (running)
            {
                Thread.Sleep(10);
                device.joystick.Poll();
                foreach (JoystickUpdate update in device.joystick.GetBufferedData())
                {
                    for (int i = 0; i < device.controls.Count; i++)
                    {
						if (device.controls[i].axis == update.Offset)
						{
							int value = update.Value;
							if (device.controls[i].inverted) value = (device.controls[i].joyMax - device.controls[i].joyMin) - update.Value;
							device.controls[i].trainLast = (float)(value - device.controls[i].joyMin) / (float)(device.controls[i].joyMax - device.controls[i].joyMin) * (device.controls[i].trainMax - device.controls[i].trainMin) + device.controls[i].trainMin;
						}
                    }
                }
				for (int i = 0; i < device.controls.Count; i++)
				{
					TS.SetControl(device.controls[i].tsid, device.controls[i].trainLast);
				}
            }
            Debug.WriteLine("Exiting thread: " + deviceIndex);
        }
    }
}
