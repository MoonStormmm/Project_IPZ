using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MyBugs : Form
    {
        public MyBugs()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            head hed = new head();
            hed.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            developer dev = new developer();
            dev.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tester tes = new tester();
            tes.ShowDialog();
        }


        private void button_example_Click(object sender, EventArgs e)
        {
            examples ex = new examples();
            ex.ShowDialog();
        }

        private void button_message_Click(object sender, EventArgs e)
        {
            Send s = new Send();
            s.ShowDialog();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }        
    }
}
