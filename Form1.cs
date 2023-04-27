namespace TSAnalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TS.Connect()) return;
            MessageBox.Show("Connection to Train Sim was successful.", "Connected");
            Main main = new Main();
            main.Show();
        }
    }
}