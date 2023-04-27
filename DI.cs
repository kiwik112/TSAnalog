using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;

namespace TSAnalog
{
    internal class DI
    {
        static List<Joystick> joysticks = new List<Joystick>();
        public static Joystick? joystick;
        public static string[] Init1()
        {
            DirectInput directInput = new DirectInput();
            List<string> names = new List<string>();
            Guid joystickGuid = Guid.Empty;
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
        public static void Init2(int index)
        {
            joystick = joysticks[index];
            MessageBox.Show(joystick.Information.ProductName, "Connected:");
        }
    }
}
