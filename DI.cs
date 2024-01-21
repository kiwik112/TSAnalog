using System.Diagnostics;using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using SharpDX.DirectInput;

namespace TSAnalog
{
    internal class DI
    {
        public static Dictionary<string, int> Axes = new Dictionary<string, int>();
        public static List<string> SelectedAxes = new List<string>();

        public static List<Joystick> joysticks = new List<Joystick>();

        public static JoystickOffset[] AllAxes = { JoystickOffset.X, JoystickOffset.Y, JoystickOffset.Z, JoystickOffset.RotationX, JoystickOffset.RotationY, JoystickOffset.RotationZ, JoystickOffset.Sliders0, JoystickOffset.Sliders1 };
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
            if (joystick == null) return -1;
            joystick.Poll();
            int value = -1;
            foreach (JoystickUpdate update in joystick.GetBufferedData())
            {
                Debug.WriteLine($"Update: {update.Offset.ToString()} {axis} {update.Value}");
                if (update.Offset.ToString() == axis)
                {
                    value = update.Value;
                }
            }
            return value;
        }

        public static JoystickOffset[] GetAxes(Joystick joystick)
        {
            if (joystick == null) return Array.Empty<JoystickOffset>();
            string[] axes = { "X", "Y", "Z", "RotationX", "RotationY", "RotationZ", "Sliders0", "Sliders1" };
            List<JoystickOffset> available = new List<JoystickOffset>();
            foreach (JoystickOffset axis in AllAxes)
            {
                try
                {
                    joystick.GetObjectInfoByOffset((int)axis);
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
                available.Add((JoystickOffset)(48 + i));
            }
            return available.ToArray();
        }
    }
}
