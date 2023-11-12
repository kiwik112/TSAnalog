using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using device = TSAnalog.Interface.ActiveDevices[deviceID];

namespace TSAnalog
{
    public partial class Controls : Form
    {
        public int deviceID;
        public Controls()
        {
            InitializeComponent();
        }

        private void Controls_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Interface.ActiveDevices[device].controls.Add(new Control() { name = "Control " + Interface.ActiveDevices[device].controls.Count() });
        }

        private void lsBxControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsBxControls.SelectedIndex != -1)
            {
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ControlDialog controlDialog = new ControlDialog() { device = device };
            controlDialog.ShowDialog();

        }
        
        private void refresh()
        {
            lsBxControls.Items.Clear();
            foreach (Control control in Interface.ActiveDevices[device].controls)
            {

            }
        }
    }
}
