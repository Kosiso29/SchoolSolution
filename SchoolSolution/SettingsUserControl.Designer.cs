namespace SchoolSolution
{
    partial class SettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUserControl));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.saveToPDFCheckBox = new System.Windows.Forms.CheckBox();
            this.selectPrinterCheckBox = new System.Windows.Forms.CheckBox();
            this.setPrinterCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showPrintPreviewCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(69, 66);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 2;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveToPDFCheckBox
            // 
            this.saveToPDFCheckBox.AutoSize = true;
            this.saveToPDFCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.saveToPDFCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToPDFCheckBox.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToPDFCheckBox.Location = new System.Drawing.Point(371, 94);
            this.saveToPDFCheckBox.Name = "saveToPDFCheckBox";
            this.saveToPDFCheckBox.Size = new System.Drawing.Size(116, 58);
            this.saveToPDFCheckBox.TabIndex = 3;
            this.saveToPDFCheckBox.Text = "OFF";
            this.saveToPDFCheckBox.UseVisualStyleBackColor = true;
            this.saveToPDFCheckBox.CheckedChanged += new System.EventHandler(this.saveToPDFCheckBox_CheckedChanged);
            // 
            // selectPrinterCheckBox
            // 
            this.selectPrinterCheckBox.AutoSize = true;
            this.selectPrinterCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.selectPrinterCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPrinterCheckBox.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrinterCheckBox.Location = new System.Drawing.Point(818, 98);
            this.selectPrinterCheckBox.Name = "selectPrinterCheckBox";
            this.selectPrinterCheckBox.Size = new System.Drawing.Size(116, 58);
            this.selectPrinterCheckBox.TabIndex = 4;
            this.selectPrinterCheckBox.Text = "OFF";
            this.selectPrinterCheckBox.UseVisualStyleBackColor = true;
            this.selectPrinterCheckBox.CheckedChanged += new System.EventHandler(this.selectPrinterCheckBox_CheckedChanged);
            // 
            // setPrinterCheckBox
            // 
            this.setPrinterCheckBox.AutoSize = true;
            this.setPrinterCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.setPrinterCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPrinterCheckBox.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPrinterCheckBox.Location = new System.Drawing.Point(371, 186);
            this.setPrinterCheckBox.Name = "setPrinterCheckBox";
            this.setPrinterCheckBox.Size = new System.Drawing.Size(116, 58);
            this.setPrinterCheckBox.TabIndex = 5;
            this.setPrinterCheckBox.Text = "OFF";
            this.setPrinterCheckBox.UseVisualStyleBackColor = true;
            this.setPrinterCheckBox.CheckedChanged += new System.EventHandler(this.setPrinterCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Save to PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Printer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set Printer";
            // 
            // printerName
            // 
            this.printerName.BackColor = System.Drawing.Color.Yellow;
            this.printerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printerName.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerName.Location = new System.Drawing.Point(535, 188);
            this.printerName.Name = "printerName";
            this.printerName.Size = new System.Drawing.Size(261, 61);
            this.printerName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 54);
            this.label4.TabIndex = 11;
            this.label4.Text = "Show Print Preview";
            // 
            // showPrintPreviewCheckBox
            // 
            this.showPrintPreviewCheckBox.AutoSize = true;
            this.showPrintPreviewCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.showPrintPreviewCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPrintPreviewCheckBox.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPrintPreviewCheckBox.Location = new System.Drawing.Point(492, 261);
            this.showPrintPreviewCheckBox.Name = "showPrintPreviewCheckBox";
            this.showPrintPreviewCheckBox.Size = new System.Drawing.Size(116, 58);
            this.showPrintPreviewCheckBox.TabIndex = 10;
            this.showPrintPreviewCheckBox.Text = "OFF";
            this.showPrintPreviewCheckBox.UseVisualStyleBackColor = true;
            this.showPrintPreviewCheckBox.CheckedChanged += new System.EventHandler(this.showPrintPreviewCheckBox_CheckedChanged);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showPrintPreviewCheckBox);
            this.Controls.Add(this.printerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setPrinterCheckBox);
            this.Controls.Add(this.selectPrinterCheckBox);
            this.Controls.Add(this.saveToPDFCheckBox);
            this.Controls.Add(this.backButton);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1075, 563);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.CheckBox saveToPDFCheckBox;
        private System.Windows.Forms.CheckBox selectPrinterCheckBox;
        private System.Windows.Forms.CheckBox setPrinterCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox printerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showPrintPreviewCheckBox;
    }
}
