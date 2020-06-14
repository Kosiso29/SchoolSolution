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
using System.Drawing.Printing;
using System.IO;

namespace SchoolSolution
{
    public partial class NurseryUserControl : UserControl
    {
        public NurseryUserControl()
        {
            InitializeComponent();
            connection();
            fillList();
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

        private void FillPageItems()
        {
            if (numberTextbox.Text != "" && int.Parse(numberTextbox.Text) < countList && int.Parse(numberTextbox.Text) >= 0)
            {
                //if (pictureBox2.Image != null)
                    //pictureBox2.Image = null;

                SqlCommand commander = new SqlCommand("select * from Result where id='" + ResultId[int.Parse(numberTextbox.Text)] + "';", myconn);
                SqlDataReader myreader;
                try
                {
                    myconn.Open();
                    myreader = commander.ExecuteReader();

                    while (myreader.Read())
                    {
                        if (!myreader.IsDBNull(1))
                            label22.Text = myreader.GetString(1);
                        if (!myreader.IsDBNull(2))
                            label23.Text = myreader.GetString(2);
                        if (!myreader.IsDBNull(3))
                            label24.Text = myreader.GetString(3);
                        if (!myreader.IsDBNull(4))
                            label25.Text = myreader.GetInt32(4).ToString();
                        if (!myreader.IsDBNull(5))
                            label26.Text = myreader.GetInt32(5).ToString();
                        if (!myreader.IsDBNull(6))
                            label27.Text = myreader.GetInt32(6).ToString();
                        if (!myreader.IsDBNull(7))
                            label28.Text = myreader.GetInt32(7).ToString();
                        if (!myreader.IsDBNull(8))
                            label29.Text = myreader.GetString(8);
                        if (!myreader.IsDBNull(9))
                            label30.Text = myreader.GetString(9);
                        if (!myreader.IsDBNull(10))
                            label11.Text = myreader.GetString(10);
                        if (!myreader.IsDBNull(11))
                            label12.Text = myreader.GetString(11);
                        if (!myreader.IsDBNull(12))//subject1
                            button2.Text = myreader.GetString(12);
                        if (!myreader.IsDBNull(13))
                            button16.Text = myreader.GetInt32(13).ToString();
                        if (!myreader.IsDBNull(14))
                            button15.Text = myreader.GetInt32(14).ToString();
                        if (!myreader.IsDBNull(13) && !myreader.IsDBNull(14))
                            button14.Text = (myreader.GetInt32(13) + myreader.GetInt32(14)).ToString();
                        if (!myreader.IsDBNull(15))
                            button13.Text = myreader.GetString(15);
                        if (!myreader.IsDBNull(16))//subject2
                            button3.Text = myreader.GetString(16);
                        if (!myreader.IsDBNull(17))
                            button20.Text = myreader.GetInt32(17).ToString();
                        if (!myreader.IsDBNull(18))
                            button19.Text = myreader.GetInt32(18).ToString();
                        if (!myreader.IsDBNull(17) && !myreader.IsDBNull(18))
                            button18.Text = (myreader.GetInt32(17) + myreader.GetInt32(18)).ToString();
                        if (!myreader.IsDBNull(19))
                            button17.Text = myreader.GetString(19);
                        if (!myreader.IsDBNull(20))//subject3
                            button4.Text = myreader.GetString(20);
                        if (!myreader.IsDBNull(21))
                            button24.Text = myreader.GetInt32(21).ToString();
                        if (!myreader.IsDBNull(22))
                            button23.Text = myreader.GetInt32(22).ToString();
                        if (!myreader.IsDBNull(21) && !myreader.IsDBNull(22))
                            button22.Text = (myreader.GetInt32(21) + myreader.GetInt32(22)).ToString();
                        if (!myreader.IsDBNull(23))
                            button21.Text = myreader.GetString(23);
                        if (!myreader.IsDBNull(24))//subject4
                            button5.Text = myreader.GetString(24);
                        if (!myreader.IsDBNull(25))
                            button28.Text = myreader.GetInt32(25).ToString();
                        if (!myreader.IsDBNull(26))
                            button27.Text = myreader.GetInt32(26).ToString();
                        if (!myreader.IsDBNull(25) && !myreader.IsDBNull(26))
                            button26.Text = (myreader.GetInt32(25) + myreader.GetInt32(26)).ToString();
                        if (!myreader.IsDBNull(27))
                            button25.Text = myreader.GetString(27);
                        if (!myreader.IsDBNull(28))//subject5
                            button6.Text = myreader.GetString(28);
                        if (!myreader.IsDBNull(29))
                            button32.Text = myreader.GetInt32(29).ToString();
                        if (!myreader.IsDBNull(30))
                            button31.Text = myreader.GetInt32(30).ToString();
                        if (!myreader.IsDBNull(29) && !myreader.IsDBNull(30))
                            button30.Text = (myreader.GetInt32(29) + myreader.GetInt32(30)).ToString();
                        if (!myreader.IsDBNull(31))
                            button29.Text = myreader.GetString(31);
                        if (!myreader.IsDBNull(32))//subject6
                            button7.Text = myreader.GetString(32);
                        if (!myreader.IsDBNull(33))
                            button36.Text = myreader.GetInt32(33).ToString();
                        if (!myreader.IsDBNull(34))
                            button35.Text = myreader.GetInt32(34).ToString();
                        if (!myreader.IsDBNull(33) && !myreader.IsDBNull(34))
                            button34.Text = (myreader.GetInt32(33) + myreader.GetInt32(34)).ToString();
                        if (!myreader.IsDBNull(35))
                            button33.Text = myreader.GetString(35);
                        if (!myreader.IsDBNull(36))//subject7
                            button8.Text = myreader.GetString(36);
                        if (!myreader.IsDBNull(37))
                            button40.Text = myreader.GetInt32(37).ToString();
                        if (!myreader.IsDBNull(38))
                            button39.Text = myreader.GetInt32(38).ToString();
                        if (!myreader.IsDBNull(37) && !myreader.IsDBNull(38))
                            button38.Text = (myreader.GetInt32(37) + myreader.GetInt32(38)).ToString();
                        if (!myreader.IsDBNull(39))
                            button37.Text = myreader.GetString(39);
                        if (!myreader.IsDBNull(40))//subject8
                            button45.Text = myreader.GetString(40);
                        if (!myreader.IsDBNull(41))
                            button44.Text = myreader.GetInt32(41).ToString();
                        if (!myreader.IsDBNull(42))
                            button43.Text = myreader.GetInt32(42).ToString();
                        if (!myreader.IsDBNull(41) && !myreader.IsDBNull(42))
                            button42.Text = (myreader.GetInt32(41) + myreader.GetInt32(42)).ToString();
                        if (!myreader.IsDBNull(43))
                            button41.Text = myreader.GetString(43);
                        if (!myreader.IsDBNull(44))//subject9
                            button50.Text = myreader.GetString(44);
                        if (!myreader.IsDBNull(45))
                            button49.Text = myreader.GetInt32(45).ToString();
                        if (!myreader.IsDBNull(46))
                            button48.Text = myreader.GetInt32(46).ToString();
                        if (!myreader.IsDBNull(45) && !myreader.IsDBNull(46))
                            button47.Text = (myreader.GetInt32(45) + myreader.GetInt32(46)).ToString();
                        if (!myreader.IsDBNull(47))
                            button46.Text = myreader.GetString(47);
                        if (!myreader.IsDBNull(13) && !myreader.IsDBNull(14) &&
                            !myreader.IsDBNull(17) && !myreader.IsDBNull(18) &&
                            !myreader.IsDBNull(21) && !myreader.IsDBNull(22) &&
                            !myreader.IsDBNull(25) && !myreader.IsDBNull(26) &&
                            !myreader.IsDBNull(29) && !myreader.IsDBNull(30) &&
                            !myreader.IsDBNull(33) && !myreader.IsDBNull(34) &&
                            !myreader.IsDBNull(37) && !myreader.IsDBNull(38) &&
                            !myreader.IsDBNull(41) && !myreader.IsDBNull(42) &&
                            !myreader.IsDBNull(45) && !myreader.IsDBNull(46))
                            button52.Text = ((myreader.GetInt32(13) + myreader.GetInt32(14) +
                                myreader.GetInt32(17) + myreader.GetInt32(18) +
                                myreader.GetInt32(21) + myreader.GetInt32(22) +
                                myreader.GetInt32(25) + myreader.GetInt32(26) +
                                myreader.GetInt32(29) + myreader.GetInt32(30) +
                                myreader.GetInt32(33) + myreader.GetInt32(34) +
                                myreader.GetInt32(37) + myreader.GetInt32(38) +
                                myreader.GetInt32(41) + myreader.GetInt32(42) +
                                myreader.GetInt32(45) + myreader.GetInt32(46))/9).ToString();                        

                        byte[] imgg;

                        if (!Convert.IsDBNull(myreader["picture"]))
                        {
                            imgg = (byte[])(myreader["picture"]);
                            //byte[] imgg = (byte[])(myreader["picture"]);
                            if (imgg == null)
                            {
                                //pictureBox2.Image = null;
                            }
                            else
                            {
                                MemoryStream mstream = new MemoryStream(imgg);
                                pictureBox2.Image = System.Drawing.Image.FromStream(mstream);
                            }

                        }
                        else
                        {
                            pictureBox2.Image = null;
                        }

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

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            PrintController printController = new StandardPrintController();
            printDocument.PrintController = printController;


            printDialog.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
        }

        private void printer()
        {
            string file = "Result Sheet " + DateTime.Now.ToString("_d_M_yyyy_hh_mm_ss");
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            PrintDocument doc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true,
                    PrintFileName = Path.Combine(directory, file + ".pdf"),
                }
            };
            PrintController printController = new StandardPrintController();
            doc.PrintController = printController;

            doc.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            doc.Print();
        }

        private void printed()
        {
            string file = "Transaction" + DateTime.Now.ToString("_d_M_yyyy_hh_mm_ss");
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            PrintDocument doc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = Properties.Settings.Default.printername,
                    PrintToFile = true,
                    PrintFileName = Path.Combine(directory, file + ".pdf"),
                }
            };
            PrintController printController = new StandardPrintController();
            doc.PrintController = printController;

            doc.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            doc.Print();

        }

        private void Print(Panel printPanel)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();
            PrinterSettings printerSettings = new PrinterSettings();
            panel1 = printPanel;
            getPrintArea(panel1);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            if (Properties.Settings.Default.printPreview == "ON")
            {
                printPreviewDialog.ShowDialog();
            }
            if (Properties.Settings.Default.printPDF == "ON")
            {
                printer();
            }
            if (Properties.Settings.Default.printer == "ON")
            {
                PrintReceipt();
            }
            if (Properties.Settings.Default.Setprinter == "ON")
            {
                printed();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            //e.Graphics.DrawImage(memorying, (pageArea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
            e.Graphics.DrawImage(memorying, this.panel1.Location.X, this.panel1.Location.Y - (this.panel1.Location.Y / 2));
        }

        Bitmap memorying;

        private void getPrintArea(Panel printPanel)
        {
            memorying = new Bitmap(printPanel.Width, printPanel.Height);
            printPanel.DrawToBitmap(memorying, new Rectangle(0, 0, printPanel.Width, printPanel.Height));
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        List<int> ResultId = new List<int>();
        int countList = 0;

        private void fillList()
        {
            SqlCommand commander = new SqlCommand("select Id from Result;", myconn);
            SqlDataReader myreader;
            try
            {
                myconn.Open();
                myreader = commander.ExecuteReader();

                while (myreader.Read())
                {
                    ResultId.Add(myreader.GetInt32(0));
                    countList = countList + 1;
                }
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                myconn.Close();
            }
        }

        private void numberTextbox_Leave(object sender, EventArgs e)
        {
            FillPageItems();
        }

        private void numberTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillPageItems();
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            int number = -1;
            if (numberTextbox.Text != "")
                number = int.Parse(numberTextbox.Text);
            if (number < countList - 1)
            {
                number = number + 1;
                numberTextbox.Text = number.ToString();
                FillPageItems();
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            int number = countList;
            if (numberTextbox.Text != "")
                number = int.Parse(numberTextbox.Text);
            if (number > 0)
            {
                number = number - 1;
                numberTextbox.Text = number.ToString();
                FillPageItems();
            }
        }

    }
}
