using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string axis;
        public bool inverted;
    }
}
