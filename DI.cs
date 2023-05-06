using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;

namespace TSAnalog
{
    internal class DI
    {
        public static Dictionary<string, int> Axes = new Dictionary<string, int>();
        public static List<string> SelectedAxes = new List<string>();

        static List<Joystick> joysticks = new List<Joystick>();
        static Joystick? joystick;
        public static string[] GetDevices()
        {
            DirectInput directInput = new DirectInput();
            List<string> names = new List<string>();
            foreach (DeviceInstance deviceInstance in directInput.GetDevices())
            {
                Debug.WriteLine(deviceInstance.InstanceGuid);
                if (deviceInstance.InstanceGuid == Guid.Empty) continue;
                joysticks.Add(new Joystick(directInput, deviceInstance.InstanceGuid));
            }
            foreach (Joystick joy in joysticks)
            {
                names.Add(joy.Information.ProductName);
            }
            return names.ToArray();
        }

        public static void SetDevice(int index)
        {
            if (joystick == joysticks[index]) return;
            joystick = joysticks[index];
            MessageBox.Show(joystick.Information.ProductName, "Connected:");
            joystick.Properties.BufferSize = 128;
            joystick.Acquire();
        }

        public static JoystickUpdate[] Get()
        {
            if (joystick == null) return Array.Empty<JoystickUpdate>();
            joystick.Poll();
            return joystick.GetBufferedData();
        }

        public static int Get(string axis)
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

        public static string[] GetAxes()
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
