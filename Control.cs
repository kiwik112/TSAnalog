using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSAnalog
{
    internal class Control
    {
        public string Name;
        public int Type;
        public string Device;
        public string Axis;
        public Point Point1 = new Point();
        public Point Point2 = new Point();

        public Control(string controlName, int trainControl, string joystick, string joystickAxis, Point controlPoint1, Point controlPoint2)
        {
            Name = controlName;
            Type = trainControl;
            Device = joystick;
            Axis = joystickAxis;
            Point1 = controlPoint1;
            Point2 = controlPoint2;
        }
    }
}
