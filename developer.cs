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
    public partial class developer : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=dbofbags.accdb");
        OleDbCommand com = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        

        public developer()
        {
            InitializeComponent();
        }

        private void developer_Load(object sender, EventArgs e)
        {
            dev_load();
        }

        public void dev_load() 
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
                ad.SelectCommand = new OleDbCommand("SELECT * From " + comboBox1.SelectedItem + " Where (name_bag LIKE '" + listBox1.SelectedItem + "')", con);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                con.Open();
                OleDbDataAdapter dbAdapter1 = new OleDbDataAdapter("SELECT name_bag From "+ comboBox1.SelectedItem, con);
                DataTable dataTable = new DataTable();
                dbAdapter1.Fill(dataTable);
                con.Close();
                DataRow[] result = dataTable.Select();
                foreach (var row in result)
                {
                    listBox1.Items.Add(row[0].ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_dgv();
        }

        private void estimate_button_Click(object sender, EventArgs e)
        {                
                try
                {
                    OleDbDataAdapter ad = new OleDbDataAdapter();
                    ad.UpdateCommand = new OleDbCommand("UPDATE " + comboBox1.SelectedItem + " SET status = '" + comboBox2.SelectedItem + "' where (name_bag ='" + listBox1.SelectedItem + "');", con);
                    con.Open();
                    ad.UpdateCommand.ExecuteNonQuery();
                    con.Close();
                    load_dgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString() == "")
                {
                    textBox1.Text = "-";
                }
                else
                {
                    textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
