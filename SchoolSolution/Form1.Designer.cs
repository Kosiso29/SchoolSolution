namespace SchoolSolution
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.userCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.subjectButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.staffUserControl1 = new SchoolSolution.StaffUserControl();
            this.studentUserControl1 = new SchoolSolution.StudentUserControl();
            this.classUserControl1 = new SchoolSolution.ClassUserControl();
            this.resultUserControl1 = new SchoolSolution.ResultUserControl();
            this.settingsUserControl1 = new SchoolSolution.SettingsUserControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 100);
            this.panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(1118, 28);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(178, 54);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "DE-GIFTED SCHOOLS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.settingsButton);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.resultButton);
            this.panel2.Controls.Add(this.subjectButton);
            this.panel2.Controls.Add(this.studentButton);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.staffButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1308, 637);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.userCombobox);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1308, 637);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1195, 580);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // userCombobox
            // 
            this.userCombobox.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCombobox.FormattingEnabled = true;
            this.userCombobox.Items.AddRange(new object[] {
            "Admin",
            "Teacher"});
            this.userCombobox.Location = new System.Drawing.Point(179, 438);
            this.userCombobox.Name = "userCombobox";
            this.userCombobox.Size = new System.Drawing.Size(393, 62);
            this.userCombobox.TabIndex = 2;
            this.userCombobox.Text = "Admin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.passwordTextbox);
            this.groupBox1.Controls.Add(this.usernameTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(615, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 513);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Orange;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(46, 386);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(181, 62);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(46, 288);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(363, 61);
            this.passwordTextbox.TabIndex = 3;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(46, 140);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(363, 61);
            this.usernameTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(393, 305);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Yellow;
            this.logoutButton.FlatAppearance.BorderSize = 3;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.Location = new System.Drawing.Point(661, 289);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(282, 127);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Yellow;
            this.settingsButton.FlatAppearance.BorderSize = 3;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsButton.Location = new System.Drawing.Point(373, 289);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(282, 127);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(85, 289);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(282, 127);
            this.button7.TabIndex = 6;
            this.button7.Text = "Admission";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(661, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(282, 127);
            this.button6.TabIndex = 5;
            this.button6.Text = "Timetable";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // resultButton
            // 
            this.resultButton.BackColor = System.Drawing.Color.Yellow;
            this.resultButton.FlatAppearance.BorderSize = 3;
            this.resultButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.resultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultButton.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultButton.Image = ((System.Drawing.Image)(resources.GetObject("resultButton.Image")));
            this.resultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultButton.Location = new System.Drawing.Point(373, 156);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(282, 127);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "Result";
            this.resultButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultButton.UseVisualStyleBackColor = false;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // subjectButton
            // 
            this.subjectButton.BackColor = System.Drawing.Color.Yellow;
            this.subjectButton.FlatAppearance.BorderSize = 3;
            this.subjectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.subjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectButton.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectButton.Image = ((System.Drawing.Image)(resources.GetObject("subjectButton.Image")));
            this.subjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subjectButton.Location = new System.Drawing.Point(85, 156);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Size = new System.Drawing.Size(282, 127);
            this.subjectButton.TabIndex = 3;
            this.subjectButton.Text = "Subject";
            this.subjectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectButton.UseVisualStyleBackColor = false;
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.Color.Yellow;
            this.studentButton.FlatAppearance.BorderSize = 3;
            this.studentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentButton.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButton.Image = ((System.Drawing.Image)(resources.GetObject("studentButton.Image")));
            this.studentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentButton.Location = new System.Drawing.Point(661, 23);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(282, 127);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Student";
            this.studentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(373, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 127);
            this.button2.TabIndex = 1;
            this.button2.Text = "Class";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // staffButton
            // 
            this.staffButton.BackColor = System.Drawing.Color.Yellow;
            this.staffButton.FlatAppearance.BorderSize = 3;
            this.staffButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.staffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffButton.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffButton.Image = ((System.Drawing.Image)(resources.GetObject("staffButton.Image")));
            this.staffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.staffButton.Location = new System.Drawing.Point(85, 23);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(282, 127);
            this.staffButton.TabIndex = 0;
            this.staffButton.Text = "Staff";
            this.staffButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffButton.UseVisualStyleBackColor = false;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // staffUserControl1
            // 
            this.staffUserControl1.BackColor = System.Drawing.Color.Yellow;
            this.staffUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffUserControl1.Location = new System.Drawing.Point(0, 0);
            this.staffUserControl1.Name = "staffUserControl1";
            this.staffUserControl1.Size = new System.Drawing.Size(1308, 737);
            this.staffUserControl1.TabIndex = 9;
            // 
            // studentUserControl1
            // 
            this.studentUserControl1.BackColor = System.Drawing.Color.Yellow;
            this.studentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.studentUserControl1.Name = "studentUserControl1";
            this.studentUserControl1.Size = new System.Drawing.Size(1308, 737);
            this.studentUserControl1.TabIndex = 10;
            // 
            // classUserControl1
            // 
            this.classUserControl1.BackColor = System.Drawing.Color.Yellow;
            this.classUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classUserControl1.Location = new System.Drawing.Point(0, 0);
            this.classUserControl1.Name = "classUserControl1";
            this.classUserControl1.Size = new System.Drawing.Size(1308, 737);
            this.classUserControl1.TabIndex = 11;
            // 
            // resultUserControl1
            // 
            this.resultUserControl1.BackColor = System.Drawing.Color.Yellow;
            this.resultUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultUserControl1.Location = new System.Drawing.Point(0, 0);
            this.resultUserControl1.Name = "resultUserControl1";
            this.resultUserControl1.Size = new System.Drawing.Size(1308, 737);
            this.resultUserControl1.TabIndex = 12;
            // 
            // settingsUserControl1
            // 
            this.settingsUserControl1.BackColor = System.Drawing.Color.Yellow;
            this.settingsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.settingsUserControl1.Name = "settingsUserControl1";
            this.settingsUserControl1.Size = new System.Drawing.Size(1308, 737);
            this.settingsUserControl1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.staffUserControl1);
            this.Controls.Add(this.studentUserControl1);
            this.Controls.Add(this.classUserControl1);
            this.Controls.Add(this.resultUserControl1);
            this.Controls.Add(this.settingsUserControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button subjectButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button button2;
        private StaffUserControl staffUserControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ComboBox userCombobox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private StudentUserControl studentUserControl1;
        private ClassUserControl classUserControl1;
        private ResultUserControl resultUserControl1;
        private SettingsUserControl settingsUserControl1;
    }
}

