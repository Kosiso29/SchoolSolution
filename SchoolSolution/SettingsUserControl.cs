using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSolution
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            if (Properties.Settings.Default.printPDF == "ON")
            {
                saveToPDFCheckBox.CheckState = CheckState.Checked;
                saveToPDFCheckBox.Text = "ON";
            }
            if (Properties.Settings.Default.printer == "ON")
            {
                selectPrinterCheckBox.CheckState = CheckState.Checked;
                selectPrinterCheckBox.Text = "ON";
            }
            if (Properties.Settings.Default.Setprinter == "ON")
            {
                setPrinterCheckBox.CheckState = CheckState.Checked;
                setPrinterCheckBox.Text = "ON";
            }
            if (Properties.Settings.Default.printPreview == "ON")
            {
                showPrintPreviewCheckBox.CheckState = CheckState.Checked;
                showPrintPreviewCheckBox.Text = "ON";
            }
            printerName.Text = Properties.Settings.Default.printername;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveToPDFCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (saveToPDFCheckBox.Checked == true)
            {
                Properties.Settings.Default.printPDF = "ON";
                saveToPDFCheckBox.Text = "ON";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.printPDF = "OFF";
                saveToPDFCheckBox.Text = "OFF";
                Properties.Settings.Default.Save();
            }
        }

        private void selectPrinterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectPrinterCheckBox.Checked == true)
            {
                Properties.Settings.Default.printer = "ON";
                selectPrinterCheckBox.Text = "ON";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.printer = "OFF";
                selectPrinterCheckBox.Text = "OFF";
                Properties.Settings.Default.Save();
            }
        }

        private void setPrinterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (setPrinterCheckBox.Checked == true)
            {
                Properties.Settings.Default.Setprinter = "ON";
                setPrinterCheckBox.Text = "ON";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Setprinter = "OFF";
                setPrinterCheckBox.Text = "OFF";
                Properties.Settings.Default.Save();
            }
        }

        private void showPrintPreviewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPrintPreviewCheckBox.Checked == true)
            {
                Properties.Settings.Default.printPreview = "ON";
                showPrintPreviewCheckBox.Text = "ON";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.printPreview = "OFF";
                showPrintPreviewCheckBox.Text = "OFF";
                Properties.Settings.Default.Save();
            }
        }
    }
}
