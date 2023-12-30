using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Easy_DataBase_Project_V1
{
    public partial class FormContent : Form
    {
        public FormContent()
        {
            InitializeComponent();
        }

        private void show()
        {
            OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vt.mdb");
            connection.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Content order by Name",connection);
            adtr.Fill(ds,"Read Data");
            dataGridView1.DataSource = ds.Tables["Read Data"];
            connection.Close();
        }

        private void FormContent_Load(object sender, EventArgs e)
        {
            show();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult accept = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.OKCancel);

            if (accept == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddUser frame = new FormAddUser();
            frame.Show();
            this.Close();
        }

        private void ButtonDeleteUser_Click(object sender, EventArgs e)
        {
            
            if (value == true)
            {

            
            
                OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vt.mdb");
                connection.Open();
                OleDbCommand delete = new OleDbCommand("delete from Content where Kimlik=@kimlik",connection);
                delete.Parameters.AddWithValue("@kimlik", selected_user);

                DialogResult accept = MessageBox.Show("Are u sure delete ID: " + selected_user,"Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (accept == DialogResult.Yes)
                {
                    delete.ExecuteNonQuery();
                    MessageBox.Show("Delete successfully.","Info");
                }

                connection.Close();
                show();
            }

            else
            {
                MessageBox.Show("Please select any user.", "Error");
            }

        }

        string selected_user;
        bool value = false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            selected_user = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            value = true;
            Program.ID = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            Program.IdentifyNumber = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            Program.Name = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            Program.Surname = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            Program.PhoneNumber = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            Program.City = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            Program.Birthyear = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            

        }

        private void ButtonEditUser_Click(object sender, EventArgs e)
        {
            if (value == true)
            {
                FormEdit frame = new FormEdit();
                frame.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Please select any user.","Error");
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vt.mdb");
            connection.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Content where Name like '" + TextBoxSearch.Text + "%' order by Name", connection);
            adtr.Fill(ds, "Read Data");
            dataGridView1.DataSource = ds.Tables["Read Data"];
            connection.Close();
        }
    }
}
