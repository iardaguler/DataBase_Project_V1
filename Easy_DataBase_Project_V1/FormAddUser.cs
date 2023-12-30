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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void EnabledOkayButton()
        {
            if (TextBoxIdentifyNumber.Text.Length > 0 && TextBoxName.Text.Length > 0 && TextBoxSurname.Text.Length > 0 && TextBoxPhoneNumber.Text.Length > 0 && TextBoxCity.Text.Length > 0 && TextBoxBirthday.Text.Length > 0 )
            {
                ButtonSave.Enabled = true;
            }
        }

        private void DisabledOkayButton()
        {
            if (TextBoxIdentifyNumber.Text.Length == 0 || TextBoxName.Text.Length == 0 || TextBoxSurname.Text.Length == 0 || TextBoxPhoneNumber.Text.Length == 0 || TextBoxCity.Text.Length == 0 || TextBoxBirthday.Text.Length == 0)
            {
                ButtonSave.Enabled = true;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vt.mdb");
            connection.Open();


            OleDbCommand query = new OleDbCommand("select IdentifyNumber from Content where IdentifyNumber=@identifynumber", connection);
            query.Parameters.AddWithValue("@identifynumber", TextBoxIdentifyNumber.Text);
            
            
            OleDbDataReader reader = query.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Have already exist !","Error");
            }

            else
            {
                OleDbCommand command = new OleDbCommand("insert into Content(IdentifyNumber,Name,Surname,PhoneNumber,City,Birthyear) values(@IdentifyNumber,@Name,@Surname,@PhoneNumber,@City,@Birthyear)", connection);
                command.Parameters.AddWithValue("@IdentifyNumber", TextBoxIdentifyNumber.Text);
                command.Parameters.AddWithValue("@Name", TextBoxName.Text);
                command.Parameters.AddWithValue("@Surname", TextBoxSurname.Text);
                command.Parameters.AddWithValue("@PhoneNumber", TextBoxPhoneNumber.Text);
                command.Parameters.AddWithValue("@City", TextBoxCity.Text);
                command.Parameters.AddWithValue("@Birthyear", TextBoxBirthday.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Registration Successful.", "Info");
                FormContent frame = new FormContent();
                frame.Show();
                this.Close();
            }


            
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormContent frame = new FormContent();
            frame.Show();
            this.Close();
        }

        private void TextBoxIdentifyNumber_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }

        private void TextBoxSurname_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }

        private void TextBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }

        private void TextBoxCity_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }

        private void TextBoxBirthday_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            ButtonSave.Enabled = false;
        }
    }
}
