using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class head : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=dbofbags.accdb");
        OleDbCommand com = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public head()
        {
            InitializeComponent();
        }

        private void head_Load(object sender, EventArgs e)
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

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            string name = textNameTable.Text;
            
                if (textNameTable.Text == String.Empty || textAboutProject.Text == String.Empty || textProgrammer.Text == String.Empty || textTester.Text == String.Empty || textStart.Text == String.Empty || textFinish.Text == String.Empty)
                {
                    MessageBox.Show("Please, enter all items into cells");
                }
                else
                {
                    try
                    {
                        con.Open();
                        com = new OleDbCommand("CREATE TABLE " + name + "(name_bag STRING, description STRING, priority STRING, status STRING)", con);
                        com.ExecuteNonQuery();
                        
                        ad.InsertCommand = new OleDbCommand("insert into AllProject values(@NameProject,@AboutProject,@Programmer,@Tester,@Date_of_start,@Date_of_finish)", con);

                        ad.InsertCommand.Parameters.Add("@NameProject", OleDbType.VarChar).Value = textNameTable.Text.ToString();
                        ad.InsertCommand.Parameters.Add("@AboutProject", OleDbType.VarChar).Value = textAboutProject .Text.ToString();
                        ad.InsertCommand.Parameters.Add("@Programmer", OleDbType.VarChar).Value = textProgrammer.Text.ToString();
                        ad.InsertCommand.Parameters.Add("@Tester", OleDbType.VarChar).Value = textTester.Text.ToString();
                        ad.InsertCommand.Parameters.Add("@Date_of_start", OleDbType.VarChar).Value = textStart.Text.ToString();
                        ad.InsertCommand.Parameters.Add("@Date_of_finish", OleDbType.VarChar).Value = textFinish.Text.ToString();
                        
                        ad.InsertCommand.ExecuteNonQuery();
                        con.Close();

                        textNameTable.Text = String.Empty;
                        textAboutProject.Text = String.Empty;
                        textProgrammer.Text = String.Empty;
                        textTester.Text = String.Empty;
                        textStart.Text = String.Empty;
                        textFinish.Text = String.Empty;
                        
                        con.Close();               
                        MessageBox.Show("Created a new project");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }            
        }     
    }
}
