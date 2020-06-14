using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace SchoolSolution
{
    public partial class PrintResult : Form
    {
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();

        public PrintResult()
        {
            InitializeComponent();
            connection();
            UpdateFontResult();
            tableRefreshResult();
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

        private void resultClassCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultClassCombobox.SelectedIndex == 0)
            {
                nurseryUserControl1.Hide();
            }
            if (resultClassCombobox.SelectedIndex == 1)
            {
                nurseryUserControl1.Show();
                nurseryUserControl1.BringToFront();
            }
            if (resultClassCombobox.SelectedIndex == 2)
            {
                primaryUserControl1.Show();
                primaryUserControl1.BringToFront();
                
            }
        }

        private void UpdateFontResult()
        {
            foreach (DataGridViewColumn column in resultDataGridView.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                resultDataGridView.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
            }

            foreach (DataGridViewRow row in resultDataGridView.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                resultDataGridView.RowTemplate.Height = 60;
            }

            resultDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Khaki;
            resultDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            resultDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            resultDataGridView.BackgroundColor = Color.White;

            resultDataGridView.EnableHeadersVisualStyles = false;
            resultDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
            resultDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        SqlDataAdapter adapPatient;
        DataSet dsPatient;

        private void tableRefreshResult()
        {
            try
            {
                myconn.Open();
                adapPatient = new SqlDataAdapter("select * from Result", myconn);
                dsPatient = new DataSet();
                adapPatient.Fill(dsPatient, "Result");
                resultDataGridView.DataSource = dsPatient.Tables[0];
                UpdateFontResult();
                resultDataGridView.CurrentCell = null;
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
