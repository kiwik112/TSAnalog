using SharpDX.DirectInput;
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

namespace TSAnalog
{
    public partial class ControlDialog : Form
    {
        Thread? axisThread;
        static string axis = "";
        public int EditIndex = -1;
        List<int> IDs = new List<int>();

        static bool threadStarted = false;

        public ControlDialog()
        {
            COM.Paused = true;
            InitializeComponent();
        }

        private void ControlDialog_Load(object sender, EventArgs e)
        {
            lsBxControls.Items.Clear();
            string[] controls = TS.getData()[1].Split("::");
            for (int i = 0; i < controls.Length; i++)
            {
                lsBxControls.Items.Add(controls[i]);
                IDs.Add(i);
            }
            comboDevice.Items.Clear();
            foreach (string device in DI.GetDevices())
            {
                comboDevice.Items.Add(device);
            }
            comboAxis.Items.Clear();
            if (EditIndex == -1) return;

            tbName.Text = COM.Controls[EditIndex].Name;
            lsBxControls.SelectedIndex = COM.Controls[EditIndex].Type;
            comboDevice.Text = COM.Controls[EditIndex].Device;
            comboAxis.Text = COM.Controls[EditIndex].Axis;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string[] controls = TS.getData()[1].Split("::");
            lsBxControls.Items.Clear();
            IDs.Clear();
            for (int i = 0; i < controls.Length; i++)
            {
                if (!controls[i].ToLower().Contains(tbSearch.Text.ToLower())) continue;
                IDs.Add(i);
                lsBxControls.Items.Add(controls[i]);
            }
            foreach (int id in IDs)
            {
                Debug.WriteLine(id);
            }
        }

        private void comboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            DI.SetDevice(comboDevice.SelectedIndex);
            comboAxis.Items.Clear();
            foreach (string axis in DI.GetAxes())
            {
                comboAxis.Items.Add(axis);
            }
        }

        private void comboAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool wasStarted = threadStarted;
            threadStarted = false;
            Thread.Sleep(10);
            DI.SelectedAxes.Add(comboAxis.Text);
            axis = comboAxis.Text;
            threadStarted = true;
            if (wasStarted) return;
            axisThread = new Thread(testAxis);
            axisThread.Start();
        }

        private void testAxis()
        {
            while (true)
            {
                Thread.Sleep(10);
                if (!threadStarted) continue;
                int value = DI.Get(axis);
                if (value == -1) continue;
                try
                {
                    Invoke(new Action(() => { progAxis.Value = value + 1; progAxis.Value = value; }));
                    //Done twice to remove animation
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (EditIndex == -1) COM.Controls.Add(new Control(tbName.Text, IDs[lsBxControls.SelectedIndex], comboDevice.Text, comboAxis.Text, new Point(0, (int)(TS.GetControl(lsBxControls.SelectedIndex)[1] * 100)), new Point(65535, (int)(TS.GetControl(lsBxControls.SelectedIndex)[2] * 100))));
            else COM.Controls[EditIndex] = new Control(tbName.Text, IDs[lsBxControls.SelectedIndex], comboDevice.Text, comboAxis.Text, new Point(0, (int)(TS.GetControl(lsBxControls.SelectedIndex)[1] * 100)), new Point(65535, (int)(TS.GetControl(lsBxControls.SelectedIndex)[2] * 100)));
            Close();
        }

        private void ControlDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            COM.Paused = false;
        }
    }
}
