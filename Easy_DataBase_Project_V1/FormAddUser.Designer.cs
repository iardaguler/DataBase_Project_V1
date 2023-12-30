namespace Easy_DataBase_Project_V1
{
    partial class FormAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxIdentifyNumber = new System.Windows.Forms.TextBox();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxCity = new System.Windows.Forms.TextBox();
            this.TextBoxBirthday = new System.Windows.Forms.TextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(160, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(142, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Identify Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(173, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(145, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Birthyear:";
            // 
            // TextBoxIdentifyNumber
            // 
            this.TextBoxIdentifyNumber.Location = new System.Drawing.Point(213, 53);
            this.TextBoxIdentifyNumber.Name = "TextBoxIdentifyNumber";
            this.TextBoxIdentifyNumber.Size = new System.Drawing.Size(138, 20);
            this.TextBoxIdentifyNumber.TabIndex = 0;
            this.TextBoxIdentifyNumber.TextChanged += new System.EventHandler(this.TextBoxIdentifyNumber_TextChanged);
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(213, 145);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(138, 20);
            this.TextBoxSurname.TabIndex = 2;
            this.TextBoxSurname.TextChanged += new System.EventHandler(this.TextBoxSurname_TextChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(213, 99);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(138, 20);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(213, 188);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.TextBoxPhoneNumber.TabIndex = 3;
            this.TextBoxPhoneNumber.TextChanged += new System.EventHandler(this.TextBoxPhoneNumber_TextChanged);
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Location = new System.Drawing.Point(213, 237);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(138, 20);
            this.TextBoxCity.TabIndex = 4;
            this.TextBoxCity.TextChanged += new System.EventHandler(this.TextBoxCity_TextChanged);
            // 
            // TextBoxBirthday
            // 
            this.TextBoxBirthday.Location = new System.Drawing.Point(213, 283);
            this.TextBoxBirthday.Name = "TextBoxBirthday";
            this.TextBoxBirthday.Size = new System.Drawing.Size(138, 20);
            this.TextBoxBirthday.TabIndex = 5;
            this.TextBoxBirthday.TextChanged += new System.EventHandler(this.TextBoxBirthday_TextChanged);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonBack.BackgroundImage")));
            this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBack.Location = new System.Drawing.Point(295, 323);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(56, 51);
            this.ButtonBack.TabIndex = 7;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSave.Location = new System.Drawing.Point(213, 323);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(56, 51);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxBirthday);
            this.Controls.Add(this.TextBoxCity);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.TextBoxIdentifyNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxIdentifyNumber;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxCity;
        private System.Windows.Forms.TextBox TextBoxBirthday;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonBack;
    }
}