using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TSAnalog
{
    //Some of this code is 'borrowed' and/or modified from: https://github.com/luca009/RWAnalog
    internal class TS
    {
        [DllImport(@"D:\Program Files (x86)\Steam\steamapps\common\RailWorks\plugins\Raildriver64.dll")]
        static extern void SetRailDriverConnected(bool isConnected);

        [DllImport(@"D:\Program Files (x86)\Steam\steamapps\common\RailWorks\plugins\Raildriver64.dll")]
        static extern bool GetRailSimConnected();

        [DllImport(@"D:\Program Files (x86)\Steam\steamapps\common\RailWorks\plugins\Raildriver64.dll")]
        static extern IntPtr GetLocoName();

        [DllImport(@"D:\Program Files (x86)\Steam\steamapps\common\RailWorks\plugins\Raildriver64.dll")]
        static extern IntPtr GetControllerList();

        [DllImport(@"D:\Program Files (x86)\Steam\steamapps\common\RailWorks\plugins\Raildriver64.dll")]
        static extern float GetControllerValue(int controlID, int type);

        [DllImport(@"D:\Program Files (x86)\Steam\steamapps\common\RailWorks\plugins\Raildriver64.dll")]
        static extern void SetControllerValue(int controlID, float value);

        public static string[] getData()
        {
            string? name = Marshal.PtrToStringAnsi(GetLocoName());
            string? controls = Marshal.PtrToStringAnsi(GetControllerList());
            if (name == null || controls == null)
            {
                DialogResult result = MessageBox.Show("Locomotive did not report name and/or it's controls. Retry?", "Loco error", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) Application.Restart();
                Environment.Exit(1);
            }
            return new string[] { name, controls };
        }

        public static bool Connect(int secondsWait = 5)
        {
            //retry a few times in quick succession
            //íf this fails, wait a bit longer and try again
            for (int longWait = 0; longWait < secondsWait * 2; longWait++)
            {
                for (int smallWait = 0; smallWait < 5; smallWait++)
                {
                    if (GetRailSimConnected() == true)
                        return true;

                    SetRailDriverConnected(true);

                    Thread.Sleep(10);
                }

                Thread.Sleep(500);
            }

            return GetRailSimConnected();
        }
        //My code begins here
        public static float[] GetControl(int id)
        {
            float current = GetControllerValue(id, 0);
            float min = GetControllerValue(id, 1);
            float max = GetControllerValue(id, 2);
            return new float[] { current, min, max };
        }
        public static void SetControl(int id, float value)
        {
            SetControllerValue(id, value);
        }
    }
}
