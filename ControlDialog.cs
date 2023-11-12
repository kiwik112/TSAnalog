using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSAnalog
{
    public partial class ControlDialog : Form
    {
        public int device;
        public ControlDialog()
        {
            InitializeComponent();
        }

        private void ControlDialog_Load(object sender, EventArgs e)
        {
            string[] controls = TS.GetData()[1].Split("::");
            foreach (string control in controls)
            {
                lsBxDevice.Items.Add(control);
            }

            foreach (string axis in DI.GetAxes(Interface.ActiveDevices[device].joystick))
            {
                comboAxis.Items.Add(axis);
            }
        }
    }
}
