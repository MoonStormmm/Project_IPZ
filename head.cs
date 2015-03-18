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
        OleDbConnection con2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=dbofproject.accdb");
        OleDbCommand com = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();
        OleDbDataAdapter ad2 = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();

        public head()
        {
            InitializeComponent();
        }

        private void head_Load(object sender, EventArgs e)
        {
            headdataload();
        }

        public void headdataload()
        {
            existing_projec.Items.Clear();
            con.Open();
            DataTable tbls = con.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
            foreach (DataRow row in tbls.Rows)
            {
                string TableName = row["TABLE_NAME"].ToString();
                existing_projec.Items.Add(TableName);
            }
            con.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
                        con2.Open();
                        com = new OleDbCommand("CREATE TABLE " + name + "(name_bag STRING, description STRING, priority STRING, status STRING)", con);
                        com.ExecuteNonQuery();
                        
                        ad.InsertCommand = new OleDbCommand("insert into AllProject values(@NameProject,@AboutProject,@Programmer,@Tester,@Date_of_start,@Date_of_finish)", con2);

                        ad.InsertCommand.Parameters.Add("@NameProject", OleDbType.VarChar).Value = textNameTable.Text.ToString();
                        ad.InsertCommand.Parameters.Add("@AboutProject", OleDbType.VarChar).Value = textAboutProject .Text.ToString();
                        ad.InsertCommand.Parameters.Add("@Programmer", OleDbType.VarChar).Value = textProgrammer.Text.ToString();
                        ad.InsertCommand.Parameters.Add("@Tester", OleDbType.VarChar).Value = textTester.Text.ToString();
                        ad.InsertCommand.Parameters.Add("@Date_of_start", OleDbType.VarChar).Value = textStart.Text.ToString();
                        ad.InsertCommand.Parameters.Add("@Date_of_finish", OleDbType.VarChar).Value = textFinish.Text.ToString();
                        
                        ad.InsertCommand.ExecuteNonQuery();
                        con.Close();
                        con2.Close();

                        textNameTable.Text = String.Empty;
                        textAboutProject.Text = String.Empty;
                        textProgrammer.Text = String.Empty;
                        textTester.Text = String.Empty;
                        textStart.Text = String.Empty;
                        textFinish.Text = String.Empty;
                        
                        con.Close();               
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                headdataload();
        }

        private void existing_projec_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDGV1();
            loadDGV2();
        }

        public void loadDGV1() 
        {
            try
            {
                ad.SelectCommand = new OleDbCommand("SELECT * From " + existing_projec.SelectedItem, con);
                ds.Clear();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Open();
                ad.SelectCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDGV2() 
        {
            try
            {
                ad2.SelectCommand = new OleDbCommand("SELECT * From AllProject WHERE (NameProject LIKE '" + existing_projec.SelectedItem + "');", con2);
                ds2.Clear();
                ad2.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0];
                con2.Open();
                ad2.SelectCommand.ExecuteNonQuery();
                con2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
        private void button_Delete_Click(object sender, EventArgs e)
        {
                           
            try
            {
                ad.DeleteCommand = new OleDbCommand("DROP TABLE " + existing_projec.SelectedItem.ToString(), con);
                ad2.DeleteCommand = new OleDbCommand("DELETE FROM AllProject WHERE (NameProject LIKE '" + existing_projec.SelectedItem.ToString()+"')", con2);
                con.Open();
                con2.Open();
                ad.DeleteCommand.ExecuteNonQuery();
                ad2.DeleteCommand.ExecuteNonQuery();
                con.Close();
                con2.Close();
                headdataload();
                existing_projec.SelectedIndex = 0;
                loadDGV1();
                loadDGV2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }  
    }
}
