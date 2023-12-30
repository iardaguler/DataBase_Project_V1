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

namespace Easy_DataBase_Project_V1
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormContent frame = new FormContent();
            frame.Show();
            this.Close();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = Program.ID;
            TextBoxIdentifyNumber.Text = Program.IdentifyNumber;
            TextBoxName.Text = Program.Name;
            TextBoxSurname.Text = Program.Surname;
            TextBoxPhoneNumber.Text = Program.PhoneNumber;
            TextBoxCity.Text = Program.City;
            TextBoxBirthyear.Text = Program.Birthyear;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vt.mdb");
            connection.Open();
            OleDbCommand command = new OleDbCommand("update Content set IdentifyNumber=@identifynumber,Name=@name,Surname=@surname,PhoneNumber=@phonenumber,City=@city,Birthyear=@birthyear where Kimlik=@id",connection);

            command.Parameters.AddWithValue("@identifynumber",TextBoxIdentifyNumber.Text);
            command.Parameters.AddWithValue("@name", TextBoxName.Text);
            command.Parameters.AddWithValue("@surname",TextBoxSurname.Text);
            command.Parameters.AddWithValue("@phonenumber", TextBoxPhoneNumber.Text);
            command.Parameters.AddWithValue("@city",TextBoxCity.Text);
            command.Parameters.AddWithValue("@birthyear",TextBoxBirthyear.Text);
            command.Parameters.AddWithValue("@id",TextBoxID.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Edit successfully.", "Info");

            FormContent frame = new FormContent();
            frame.Show();
            this.Close();
        }
    }
}
