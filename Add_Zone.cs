using GestionBibFormGhoudan.Db;
using MySqlConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace p2
{
    public partial class Add_Zone : UserControl
    {
        private static int x = 0;
        private static int y = 0;
        private static int xhome = 1000;
        private static int yhome = 1500;
        private static int xzone = 0;
        private static int yzone = 0;
        

        public Add_Zone()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.zoneh = Convert.ToInt16(textBox1.Text);
            f.zonew = Convert.ToInt16(textBox2.Text);
            f.zonename = comboBox2.Text;
            f.Show();
            
           
            f.getZone();
        }
    }
}
