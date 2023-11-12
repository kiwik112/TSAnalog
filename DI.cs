using System.Diagnostics;using System.Threading.Tasks;
using SharpDX.DirectInput;

namespace TSAnalog
{
    internal class DI
    {
        public static Dictionary<string, int> Axes = new Dictionary<string, int>();
        public static List<string> SelectedAxes = new List<string>();

        public static List<Joystick> joysticks = new List<Joystick>();

        public static Joystick[] GetDevices()
        {
            DirectInput directInput = new DirectInput();
            joysticks = new List<Joystick>();
            foreach (DeviceInstance deviceInstance in directInput.GetDevices())
            {
                Debug.WriteLine(deviceInstance.InstanceGuid);
                if (deviceInstance.InstanceGuid == Guid.Empty) continue;
                joysticks.Add(new Joystick(directInput, deviceInstance.InstanceGuid));
            }
            return joysticks.ToArray();
        }

        public static JoystickUpdate[] Get(Joystick joystick, int index)
        {
            if (joystick == null) return Array.Empty<JoystickUpdate>();
            joystick.Poll();
            return joystick.GetBufferedData();
        }

        public static int Get(Joystick joystick, string axis)
        {
            if (joystick == null) return 0;
            joystick.Poll();
            int value = -1;
            foreach (JoystickUpdate update in joystick.GetBufferedData())
            {
                if (SelectedAxes.Contains(update.Offset.ToString()))
                {
                    Axes[update.Offset.ToString()] = update.Value;
                }

                if (update.Offset.ToString() == axis)
                {
                    value = update.Value;
                }
            }
            return Axes[axis];
        }

        public static string[] GetAxes(Joystick joystick)
        {
            if (joystick == null) return Array.Empty<string>();
            string[] axes = { "X", "Y", "Z", "RotationX", "RotationY", "RotationZ", "Rudder", "Throttle", "Accelerator", "Brake", "Steering" };
            List<string> available = new List<string>();
            foreach (string axis in axes)
            {
                try
                {
                    joystick.GetObjectInfoByName(axis);
                }
                catch
                {
                    continue;
                }
                available.Add(axis);
            }
            for (int i = 0; i < 32; i++)
            {
                try
                {
                    joystick.GetObjectInfoByName("Buttons" + i);
                }
                catch
                {
                    continue;
                }
                available.Add("Buttons" + i);
            }
            return available.ToArray();
        }
    }
}
