namespace Easy_DataBase_Project_V1
{
    partial class FormContent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContent));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonDeleteUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonEditUser = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 249);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 92);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.BackColor = System.Drawing.Color.White;
            this.ButtonAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddUser.BackgroundImage")));
            this.ButtonAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAddUser.Location = new System.Drawing.Point(149, 30);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(146, 129);
            this.ButtonAddUser.TabIndex = 0;
            this.AddUser.SetToolTip(this.ButtonAddUser, "Add User");
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonDeleteUser
            // 
            this.ButtonDeleteUser.BackColor = System.Drawing.Color.White;
            this.ButtonDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDeleteUser.BackgroundImage")));
            this.ButtonDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonDeleteUser.Location = new System.Drawing.Point(301, 30);
            this.ButtonDeleteUser.Name = "ButtonDeleteUser";
            this.ButtonDeleteUser.Size = new System.Drawing.Size(146, 129);
            this.ButtonDeleteUser.TabIndex = 1;
            this.DeleteUser.SetToolTip(this.ButtonDeleteUser, "Delete User");
            this.ButtonDeleteUser.UseVisualStyleBackColor = false;
            this.ButtonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // ButtonEditUser
            // 
            this.ButtonEditUser.BackColor = System.Drawing.Color.White;
            this.ButtonEditUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEditUser.BackgroundImage")));
            this.ButtonEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonEditUser.Location = new System.Drawing.Point(453, 30);
            this.ButtonEditUser.Name = "ButtonEditUser";
            this.ButtonEditUser.Size = new System.Drawing.Size(146, 129);
            this.ButtonEditUser.TabIndex = 2;
            this.EditUser.SetToolTip(this.ButtonEditUser, "Edit User");
            this.ButtonEditUser.UseVisualStyleBackColor = false;
            this.ButtonEditUser.Click += new System.EventHandler(this.ButtonEditUser_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(637, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Location = new System.Drawing.Point(656, 146);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(100, 13);
            this.TextBoxSearch.TabIndex = 5;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // FormContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonEditUser);
            this.Controls.Add(this.ButtonDeleteUser);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content";
            this.Load += new System.EventHandler(this.FormContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button ButtonDeleteUser;
        private System.Windows.Forms.Button ButtonEditUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip AddUser;
        private System.Windows.Forms.ToolTip DeleteUser;
        private System.Windows.Forms.ToolTip EditUser;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxSearch;
    }
}