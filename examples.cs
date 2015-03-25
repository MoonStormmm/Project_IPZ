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
    public partial class examples : Form
    {
        public examples()
        {
            InitializeComponent();
        }

        private void examples_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            try
            {
                webBrowser1.Navigate("www.google.com");             
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
