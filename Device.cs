using SharpDX.DirectInput;

namespace TSAnalog
{
    public class Device
    {
        public Joystick? joystick;
        public List<Control> controls = new List<Control>();
    }

    public class Control
    {
        public string name;
        public int tsid; // ID of control in Train Sim
        public JoystickOffset axis;
        public bool inverted;
        public int joyMin = 0;
        public int joyMax = 65535;
        public float trainMin = 0;
        public float trainMax = 0;
		public float trainLast = 0;

		public Control(string name)
		{
			this.name = name;
		}
    }
}
