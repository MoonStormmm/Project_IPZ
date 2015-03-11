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
    public partial class developer : Form
    {
        public developer()
        {
            InitializeComponent();
        }

        private void developer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Close();            
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PA pa = new PA();
            pa.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SM sm = new SM();
            sm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            examples ex = new examples();
            ex.ShowDialog();
        }

               
    }
}
namespace WindowsFormsApplication1
{
    public partial class SM : Form
    {
        public SM()
        {
            InitializeComponent();
        }
    }
}
namespace WindowsFormsApplication1
{
    public partial class PA : Form
    {
        public PA()
        {
            InitializeComponent();
        }
    }
}
