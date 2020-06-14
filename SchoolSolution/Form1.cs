using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            staffUserControl1.Hide();
            passwordTextbox.PasswordChar = '*';
            connection();
            this.ActiveControl = usernameTextbox;
            panel3.Visible = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        SqlConnection myconn;

        public void connection()
        {
            if (Properties.Settings.Default.remoteconn == "yes")
            {
                if (Properties.Settings.Default.username == "")
                {
                    myconn = new SqlConnection("Data Source='" + Properties.Settings.Default.server + "';Initial Catalog='" + Properties.Settings.Default.database + "'; integrated security = true");
                }
                else
                {
                    myconn = new SqlConnection("Data Source='" + Properties.Settings.Default.server + "';Initial Catalog='" + Properties.Settings.Default.database + "'; Persist Security Info=True;User ID = '" + Properties.Settings.Default.username + "';password = '" + Properties.Settings.Default.password + "'");
                }
            }
            else
            {
                myconn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\kosisochukwu\Documents\visual studio 2013\Projects\SchoolSolution\SchoolSolution\SchoolDatabase.mdf;Integrated Security=True");
            }
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            staffUserControl1.Show();
            staffUserControl1.BringToFront();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from " + this.userCombobox.Text + " where username= '" + this.usernameTextbox.Text + "' and password = '" + this.passwordTextbox.Text + "';", myconn);
            SqlDataReader myreader;
            try
            {
                myconn.Open();
                myreader = cmd.ExecuteReader();
                int count = 0;
                string uid = "";
                while (myreader.Read())
                {
                    count = count + 1;
                    uid = myreader.GetString(1).ToString();
                }

                if (count == 1)
                {
                    usernameLabel.Text = uid;
                    Properties.Settings.Default.usernameLabel = uid;
                    Properties.Settings.Default.Save();
                    panel3.Visible = false;
                    usernameTextbox.Focus();
                    usernameTextbox.SelectAll();
                    passwordTextbox.Clear();
                }
                else
                {
                    MessageBox.Show("username or password is incorrect!");
                }
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myconn.Close();
                passwordTextbox.SelectAll();
                passwordTextbox.Focus();
            }

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to log off?","Log off", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                panel3.Visible = true;
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            studentUserControl1.Show();
            studentUserControl1.BringToFront();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            resultUserControl1.Show();
            resultUserControl1.BringToFront();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsUserControl1.Show();
            settingsUserControl1.BringToFront();
        }
    }
}
