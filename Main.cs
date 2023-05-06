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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Thread com = new Thread(COM.Begin);
            com.Start();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConnectPrompt().ShowDialog();
            lsBxBinds.Items.Clear();
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ControlDialog().ShowDialog();
            refresh();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void refresh()
        {
            lsBxBinds.Items.Clear();
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            foreach (Control control in COM.Controls)
            {
                lsBxBinds.Items.Add(control.Name);
            }
        }

        private void lsBxBinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ControlDialog controlDialog = new ControlDialog();
            controlDialog.EditIndex = lsBxBinds.SelectedIndex;
            controlDialog.Show();
        }
    }
}
