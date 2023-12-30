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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {   
            InitializeComponent();
        }

        private void EnabledOkayButton()
        {
            if (TextBoxUsername.Text.Length > 0 && TextBoxPassword.Text.Length > 0 && TextBoxCode.Text.Length == 4)
            {
                ButtonOkay.Enabled = true;
            }
        }

        private void DisabledOkayButton()
        {
            if (TextBoxUsername.Text.Length == 0 || TextBoxPassword.Text.Length == 0 || TextBoxCode.Text.Length == 0)
            {
                ButtonOkay.Enabled = false;
            }
        }

        private void ClearAll()
        {
            TextBoxUsername.Clear();
            TextBoxPassword.Clear();
            TextBoxCode.Clear();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult accept = MessageBox.Show("Are you sure you want to exit ?", "Exit",MessageBoxButtons.OKCancel);

            if (accept == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        
        private void ButtonOkay_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=vt.mdb");
                connection.Open();
                OleDbCommand command = new OleDbCommand("select Username,Password from UserProcess where Username=@username and Password=password", connection);
                command.Parameters.AddWithValue("@username", TextBoxUsername.Text);
                command.Parameters.AddWithValue("@password", TextBoxPassword.Text);
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (code == Convert.ToInt16(TextBoxCode.Text))
                    {
                        FormContent form = new FormContent();
                        form.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Security code incorrect.", "Error !");
                    }
                    

                }

                else
                {
                    connection.Close();
                    MessageBox.Show("Username or Password incorrect.", "Error !");
                    
                    Random random = new Random();
                    code = random.Next(1000, 9999);
                    LabelRandomCode.Text = code.ToString();
                }
            
            }
            
            catch (Exception)
            {
                MessageBox.Show("Please enter your username and password.", "Error !");

                Random random = new Random();
                code = random.Next(1000, 9999);
                LabelRandomCode.Text = code.ToString();
            }

            finally
            {
               ClearAll();

            }
           
        }

        int code;

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {
            ButtonOkay.Enabled = false;
            
            Random random = new Random();
            code = random.Next(1000, 9999);
            LabelRandomCode.Text = code.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult accept = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.OKCancel);

            if (accept == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void TextBoxCode_TextChanged(object sender, EventArgs e)
        {
            EnabledOkayButton();
            DisabledOkayButton();
        }
    }
}
