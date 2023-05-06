using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSAnalog
{
    internal class COM
    {
        public static List<Control> Controls = new List<Control>();
        public static bool Paused = true;

        public static void Begin()
        {
            while (true)
            {
                if (Paused)
                {
                    Thread.Sleep(1000);
                    continue;
                }
                foreach (Control control in Controls.ToList())
                {
                    int get = DI.Get(control.Axis);
                    if (get == -1) continue;
                    float value = (float)get / ((float)control.Point2.X - (float)control.Point1.X) * ((float)control.Point2.Y - (float)control.Point1.Y) / 100 + (float)control.Point1.Y / 100;
                    Debug.WriteLine(value);
                    TS.SetControl(control.Type, value);
                }
            }
        }
    }
}
