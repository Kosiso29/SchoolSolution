namespace SchoolSolution
{
    partial class PrintResult
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
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.resultClassCombobox = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nurseryUserControl1 = new SchoolSolution.NurseryUserControl();
            this.primaryUserControl1 = new SchoolSolution.PrimaryUserControl();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.FlatAppearance.BorderSize = 2;
            this.leftButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(19, 12);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(57, 54);
            this.leftButton.TabIndex = 98;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.FlatAppearance.BorderSize = 2;
            this.rightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(218, 12);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(57, 54);
            this.rightButton.TabIndex = 99;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // numberTextbox
            // 
            this.numberTextbox.BackColor = System.Drawing.Color.Orange;
            this.numberTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberTextbox.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextbox.Location = new System.Drawing.Point(99, 10);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(100, 61);
            this.numberTextbox.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.resultDataGridView);
            this.panel3.Controls.Add(this.leftButton);
            this.panel3.Controls.Add(this.rightButton);
            this.panel3.Controls.Add(this.numberTextbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 663);
            this.panel3.TabIndex = 101;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.BackgroundColor = System.Drawing.Color.Orange;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Location = new System.Drawing.Point(3, 90);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(792, 379);
            this.resultDataGridView.TabIndex = 101;
            // 
            // resultClassCombobox
            // 
            this.resultClassCombobox.BackColor = System.Drawing.Color.Orange;
            this.resultClassCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultClassCombobox.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultClassCombobox.FormattingEnabled = true;
            this.resultClassCombobox.Items.AddRange(new object[] {
            "Home",
            "Nursery Result",
            "Primary Result"});
            this.resultClassCombobox.Location = new System.Drawing.Point(3, 3);
            this.resultClassCombobox.Name = "resultClassCombobox";
            this.resultClassCombobox.Size = new System.Drawing.Size(801, 62);
            this.resultClassCombobox.TabIndex = 101;
            this.resultClassCombobox.Text = "Home";
            this.resultClassCombobox.SelectedIndexChanged += new System.EventHandler(this.resultClassCombobox_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.resultClassCombobox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 68);
            this.panel4.TabIndex = 103;
            // 
            // nurseryUserControl1
            // 
            this.nurseryUserControl1.AutoScroll = true;
            this.nurseryUserControl1.BackColor = System.Drawing.Color.Orange;
            this.nurseryUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nurseryUserControl1.Location = new System.Drawing.Point(0, 0);
            this.nurseryUserControl1.Name = "nurseryUserControl1";
            this.nurseryUserControl1.Size = new System.Drawing.Size(807, 731);
            this.nurseryUserControl1.TabIndex = 102;
            // 
            // primaryUserControl1
            // 
            this.primaryUserControl1.AutoScroll = true;
            this.primaryUserControl1.BackColor = System.Drawing.Color.Orange;
            this.primaryUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryUserControl1.Location = new System.Drawing.Point(0, 0);
            this.primaryUserControl1.Name = "primaryUserControl1";
            this.primaryUserControl1.Size = new System.Drawing.Size(807, 731);
            this.primaryUserControl1.TabIndex = 104;
            // 
            // PrintResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(807, 731);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.nurseryUserControl1);
            this.Controls.Add(this.primaryUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintResult";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.TextBox numberTextbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox resultClassCombobox;
        private NurseryUserControl nurseryUserControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private PrimaryUserControl primaryUserControl1;
    }
}