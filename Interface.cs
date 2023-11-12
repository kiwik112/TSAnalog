using SharpDX.DirectInput;
using System.Threading.Tasks;

namespace TSAnalog
{
    internal class Interface
    {
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
    }
}
