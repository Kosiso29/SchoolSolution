using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SchoolSolution
{
    public partial class ResultUserControl : UserControl
    {
        public ResultUserControl()
        {
            InitializeComponent();
            connection();
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


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text != "")
            {
                if (pictureBox1.Image != null)
                {
                    byte[] imageBt = null;
                    FileStream fstream = new FileStream(str, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imageBt = br.ReadBytes((int)fstream.Length);

                    SqlCommand commander = new SqlCommand("insert into Result (name, admission_number, class, number_in_class, number_of_times_school_open, number_of_times_present, number_of_times_absent, affective, psycho_motor, term, session, subject1, subject1CA, subject1EXAM, subject1Remark, subject2, subject2CA, subject2EXAM, subject2Remark, subject3, subject3CA, subject3EXAM, subject3Remark, subject4, subject4CA, subject4EXAM, subject4Remark, subject5, subject5CA, subject5EXAM, subject5Remark, subject6, subject6CA, subject6EXAM, subject6Remark, subject7, subject7CA, subject7EXAM, subject7Remark, subject8, subject8CA, subject8EXAM, subject8Remark, subject9, subject9CA, subject9EXAM, subject9Remark, subject10, subject10CA, subject10EXAM, subject10Remark, subject11, subject11CA, subject11EXAM, subject11Remark, subject12, subject12CA, subject12EXAM, subject12Remark, picture) " +
                        "values('" + this.nameTextbox.Text + "','" + this.admissionNumberTextbox.Text + "','" + this.classTextbox.Text + "','" +
                        this.numberInClassTextbox.Text + "','" + this.numberOfTimesSchoolOpenTextbox.Text + "', '" +
                        this.numberOfTimesPresentTextbox.Text + "', '" + this.numberOfTimesAbsentTextbox.Text + "','" +
                        this.affectiveTextbox.Text + "', '" + this.psychoMotorTextbox.Text + "','" + this.termTextbox.Text + "', '" + this.sessionTextbox.Text + "', '" +
                        this.comboBox1.Text + "', '" + this.textBox12.Text + "','" + this.textBox13.Text + "','" + this.textBox15.Text + "', '" +
                        this.comboBox2.Text + "', '" + this.textBox19.Text + "','" + this.textBox18.Text + "','" + this.textBox16.Text + "', '" +
                        this.comboBox3.Text + "', '" + this.textBox23.Text + "','" + this.textBox22.Text + "','" + this.textBox20.Text + "', '" +
                        this.comboBox4.Text + "', '" + this.textBox27.Text + "','" + this.textBox26.Text + "','" + this.textBox24.Text + "', '" +
                        this.comboBox5.Text + "', '" + this.textBox31.Text + "','" + this.textBox30.Text + "','" + this.textBox28.Text + "', '" +
                        this.comboBox6.Text + "', '" + this.textBox35.Text + "','" + this.textBox34.Text + "','" + this.textBox32.Text + "', '" +
                        this.comboBox7.Text + "', '" + this.textBox39.Text + "','" + this.textBox38.Text + "','" + this.textBox36.Text + "', '" +
                        this.comboBox8.Text + "', '" + this.textBox43.Text + "','" + this.textBox42.Text + "','" + this.textBox40.Text + "', '" +
                        this.comboBox9.Text + "', '" + this.textBox47.Text + "','" + this.textBox46.Text + "','" + this.textBox44.Text + "', '" +
                        this.comboBox10.Text + "', '" + this.textBox51.Text + "','" + this.textBox50.Text + "','" + this.textBox48.Text + "', '" +
                        this.comboBox11.Text + "', '" + this.textBox55.Text + "','" + this.textBox54.Text + "','" + this.textBox52.Text + "', '" +
                        this.comboBox12.Text + "', '" + this.textBox59.Text + "','" + this.textBox58.Text + "','" + this.textBox56.Text + "', @IMG);", myconn);
                    SqlDataReader myreader;
                    try
                    {
                        myconn.Open();

                        commander.Parameters.Add(new SqlParameter("@IMG", imageBt));

                        myreader = commander.ExecuteReader();
                        MessageBox.Show("Saved!");
                        while (myreader.Read())
                        {

                        }
                        myconn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        myconn.Close();
                    }

                }
                else
                {
                    SqlCommand commander = new SqlCommand("insert into Result (name, admission_number, class, number_in_class, number_of_times_school_open, number_of_times_present, number_of_times_absent, affective, psycho_motor, term, session, subject1, subject1CA, subject1EXAM, subject1Remark, subject2, subject2CA, subject2EXAM, subject2Remark, subject3, subject3CA, subject3EXAM, subject3Remark, subject4, subject4CA, subject4EXAM, subject4Remark, subject5, subject5CA, subject5EXAM, subject5Remark, subject6, subject6CA, subject6EXAM, subject6Remark, subject7, subject7CA, subject7EXAM, subject7Remark, subject8, subject8CA, subject8EXAM, subject8Remark, subject9, subject9CA, subject9EXAM, subject9Remark, subject10, subject10CA, subject10EXAM, subject10Remark, subject11, subject11CA, subject11EXAM, subject11Remark, subject12, subject12CA, subject12EXAM, subject12Remark) " +
                        "values('" + this.nameTextbox.Text + "','" + this.admissionNumberTextbox.Text + "','" + this.classTextbox.Text + "','" +
                        this.numberInClassTextbox.Text + "','" + this.numberOfTimesSchoolOpenTextbox.Text + "', '" +
                        this.numberOfTimesPresentTextbox.Text + "', '" + this.numberOfTimesAbsentTextbox.Text + "','" +
                        this.affectiveTextbox.Text + "', '" + this.psychoMotorTextbox.Text + "','" + this.termTextbox.Text + "', '" + this.sessionTextbox.Text + "', '" +
                        this.comboBox1.Text + "', '" + this.textBox12.Text + "','" + this.textBox13.Text + "','" + this.textBox15.Text + "', '" +
                        this.comboBox2.Text + "', '" + this.textBox19.Text + "','" + this.textBox18.Text + "','" + this.textBox16.Text + "', '" +
                        this.comboBox3.Text + "', '" + this.textBox23.Text + "','" + this.textBox22.Text + "','" + this.textBox20.Text + "', '" +
                        this.comboBox4.Text + "', '" + this.textBox27.Text + "','" + this.textBox26.Text + "','" + this.textBox24.Text + "', '" +
                        this.comboBox5.Text + "', '" + this.textBox31.Text + "','" + this.textBox30.Text + "','" + this.textBox28.Text + "', '" +
                        this.comboBox6.Text + "', '" + this.textBox35.Text + "','" + this.textBox34.Text + "','" + this.textBox32.Text + "', '" +
                        this.comboBox7.Text + "', '" + this.textBox39.Text + "','" + this.textBox38.Text + "','" + this.textBox36.Text + "', '" +
                        this.comboBox8.Text + "', '" + this.textBox43.Text + "','" + this.textBox42.Text + "','" + this.textBox40.Text + "', '" +
                        this.comboBox9.Text + "', '" + this.textBox47.Text + "','" + this.textBox46.Text + "','" + this.textBox44.Text + "', '" +
                        this.comboBox10.Text + "', '" + this.textBox51.Text + "','" + this.textBox50.Text + "','" + this.textBox48.Text + "', '" +
                        this.comboBox11.Text + "', '" + this.textBox55.Text + "','" + this.textBox54.Text + "','" + this.textBox52.Text + "', '" +
                        this.comboBox12.Text + "', '" + this.textBox59.Text + "','" + this.textBox58.Text + "','" + this.textBox56.Text + "');", myconn);
                    SqlDataReader myreader;
                    try
                    {
                        myconn.Open();
                        myreader = commander.ExecuteReader();
                        MessageBox.Show("Saved!");
                        while (myreader.Read())
                        {

                        }
                        myconn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        myconn.Close();
                    }

                }
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintResult printResult = new PrintResult();
            printResult.Show();
        }

        string str;
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Select Student's Picture";
            openfile.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files (*.*)|*.*";
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                str = openfile.FileName;
                pictureBox1.ImageLocation = str;
            }
        }
    }
}
