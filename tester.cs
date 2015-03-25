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
    public partial class tester : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=dbofbags.accdb");
        OleDbCommand com = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public tester()
        {
            InitializeComponent();
        }

        private void tester_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                con.Open();
                DataTable tbls = con.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
                foreach (DataRow row in tbls.Rows)
                {
                    string TableName = row["TABLE_NAME"].ToString();
                    comboBox1.Items.Add(TableName);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_dgv() 
        {
            try
            {
                ad.SelectCommand = new OleDbCommand("SELECT * From " + comboBox1.SelectedItem, con);
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            examples ex = new examples();
            ex.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_dgv();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string name = text_name.Text;

            if (text_name.Text == String.Empty || text_desc.Text == String.Empty || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please, enter all items into cells");
            }
            else
            {
                try
                {
                    con.Open();
                    ad.InsertCommand = new OleDbCommand("insert into " +comboBox1.SelectedItem +" values(@name_bag,@description,@priority,@status)", con);

                    ad.InsertCommand.Parameters.Add("@name_bag", OleDbType.VarChar).Value = text_name.Text.ToString();
                    ad.InsertCommand.Parameters.Add("@description", OleDbType.VarChar).Value = text_desc.Text.ToString();
                    ad.InsertCommand.Parameters.Add("@priority", OleDbType.VarChar).Value = comboBox2.SelectedItem.ToString();
                    ad.InsertCommand.Parameters.Add("@status", OleDbType.VarChar).Value = "";

                    ad.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    text_name.Text = String.Empty;
                    text_desc.Text = String.Empty;
                    comboBox2.SelectedItem = String.Empty;
                  
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            load_dgv();
        }

        private void button_example_Click(object sender, EventArgs e)
        {
            examples ex = new examples();
            ex.ShowDialog();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string NameBug = (string)dataGridView1.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    ad.DeleteCommand = new OleDbCommand("DELETE * FROM " + comboBox1.SelectedItem + " WHERE (name_bag LIKE '" + NameBug + "');", con);
                    con.Open();
                    ad.DeleteCommand.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                load_dgv();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {                
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                comboBox3.SelectedIndex = 0;
                this.Size = new Size(750, 500);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please, enter all items into cells");
            }
            else 
            {
                string query = "update " + comboBox1.SelectedItem + " set name_bag='" + textBox1.Text + "',description='" + textBox2.Text + "',priority='" + comboBox3.SelectedItem + "',status='" + textBox3.Text + "' where (name_bag ='" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString() + "');";

                OleDbDataAdapter ad = new OleDbDataAdapter();
                try
                {
                    ad.UpdateCommand = new OleDbCommand(query, con);
                    con.Open();
                    ad.UpdateCommand.ExecuteNonQuery();
                    con.Close();
                    this.Size = new Size(500, 500);
                    load_dgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }      
    }
}
