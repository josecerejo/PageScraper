namespace ForeclosureDataRetriever
{
    partial class Foreclosure
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
            this.lblCOJ = new System.Windows.Forms.Label();
            this.panel_Results = new System.Windows.Forms.Panel();
            this.lbl_Rge1 = new System.Windows.Forms.Label();
            this.lbl_Median = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.lbl_Rge2 = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_YrBuilt = new System.Windows.Forms.Label();
            this.lbl_SqFt = new System.Windows.Forms.Label();
            this.lbl_Bath = new System.Windows.Forms.Label();
            this.lbl_Bed = new System.Windows.Forms.Label();
            this.lblRge2 = new System.Windows.Forms.Label();
            this.lblRge1 = new System.Windows.Forms.Label();
            this.lblMedian = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblYrBuilt = new System.Windows.Forms.Label();
            this.lblSqFt = new System.Windows.Forms.Label();
            this.lblBath = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.BrowserWindow = new System.Windows.Forms.WebBrowser();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.lstRE = new System.Windows.Forms.ListBox();
            this.panel_Results.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCOJ
            // 
            this.lblCOJ.AutoSize = true;
            this.lblCOJ.Location = new System.Drawing.Point(14, 17);
            this.lblCOJ.Name = "lblCOJ";
            this.lblCOJ.Size = new System.Drawing.Size(55, 13);
            this.lblCOJ.TabIndex = 1;
            this.lblCOJ.Text = "COJ RE#:";
            // 
            // panel_Results
            // 
            this.panel_Results.Controls.Add(this.lbl_Rge1);
            this.panel_Results.Controls.Add(this.lbl_Median);
            this.panel_Results.Controls.Add(this.lbl_Max);
            this.panel_Results.Controls.Add(this.lbl_Min);
            this.panel_Results.Controls.Add(this.lbl_Rge2);
            this.panel_Results.Controls.Add(this.lbl_Address);
            this.panel_Results.Controls.Add(this.lbl_YrBuilt);
            this.panel_Results.Controls.Add(this.lbl_SqFt);
            this.panel_Results.Controls.Add(this.lbl_Bath);
            this.panel_Results.Controls.Add(this.lbl_Bed);
            this.panel_Results.Controls.Add(this.lblRge2);
            this.panel_Results.Controls.Add(this.lblRge1);
            this.panel_Results.Controls.Add(this.lblMedian);
            this.panel_Results.Controls.Add(this.lblAddress);
            this.panel_Results.Controls.Add(this.lblYrBuilt);
            this.panel_Results.Controls.Add(this.lblSqFt);
            this.panel_Results.Controls.Add(this.lblBath);
            this.panel_Results.Controls.Add(this.lblBed);
            this.panel_Results.Controls.Add(this.lblMax);
            this.panel_Results.Controls.Add(this.lblMin);
            this.panel_Results.Location = new System.Drawing.Point(12, 271);
            this.panel_Results.Name = "panel_Results";
            this.panel_Results.Size = new System.Drawing.Size(379, 114);
            this.panel_Results.TabIndex = 4;
            // 
            // lbl_Rge1
            // 
            this.lbl_Rge1.AutoSize = true;
            this.lbl_Rge1.ForeColor = System.Drawing.Color.Green;
            this.lbl_Rge1.Location = new System.Drawing.Point(312, 29);
            this.lbl_Rge1.Name = "lbl_Rge1";
            this.lbl_Rge1.Size = new System.Drawing.Size(0, 13);
            this.lbl_Rge1.TabIndex = 19;
            // 
            // lbl_Median
            // 
            this.lbl_Median.AutoSize = true;
            this.lbl_Median.Location = new System.Drawing.Point(247, 92);
            this.lbl_Median.Name = "lbl_Median";
            this.lbl_Median.Size = new System.Drawing.Size(0, 13);
            this.lbl_Median.TabIndex = 18;
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(312, 71);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(0, 13);
            this.lbl_Max.TabIndex = 17;
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(226, 71);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(0, 13);
            this.lbl_Min.TabIndex = 16;
            // 
            // lbl_Rge2
            // 
            this.lbl_Rge2.AutoSize = true;
            this.lbl_Rge2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Rge2.Location = new System.Drawing.Point(312, 50);
            this.lbl_Rge2.Name = "lbl_Rge2";
            this.lbl_Rge2.Size = new System.Drawing.Size(0, 13);
            this.lbl_Rge2.TabIndex = 15;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(77, 5);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(0, 13);
            this.lbl_Address.TabIndex = 14;
            // 
            // lbl_YrBuilt
            // 
            this.lbl_YrBuilt.AutoSize = true;
            this.lbl_YrBuilt.Location = new System.Drawing.Point(77, 92);
            this.lbl_YrBuilt.Name = "lbl_YrBuilt";
            this.lbl_YrBuilt.Size = new System.Drawing.Size(0, 13);
            this.lbl_YrBuilt.TabIndex = 13;
            // 
            // lbl_SqFt
            // 
            this.lbl_SqFt.AutoSize = true;
            this.lbl_SqFt.Location = new System.Drawing.Point(77, 71);
            this.lbl_SqFt.Name = "lbl_SqFt";
            this.lbl_SqFt.Size = new System.Drawing.Size(0, 13);
            this.lbl_SqFt.TabIndex = 12;
            // 
            // lbl_Bath
            // 
            this.lbl_Bath.AutoSize = true;
            this.lbl_Bath.Location = new System.Drawing.Point(77, 50);
            this.lbl_Bath.Name = "lbl_Bath";
            this.lbl_Bath.Size = new System.Drawing.Size(0, 13);
            this.lbl_Bath.TabIndex = 11;
            // 
            // lbl_Bed
            // 
            this.lbl_Bed.AutoSize = true;
            this.lbl_Bed.Location = new System.Drawing.Point(77, 29);
            this.lbl_Bed.Name = "lbl_Bed";
            this.lbl_Bed.Size = new System.Drawing.Size(0, 13);
            this.lbl_Bed.TabIndex = 10;
            // 
            // lblRge2
            // 
            this.lblRge2.AutoSize = true;
            this.lblRge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRge2.ForeColor = System.Drawing.Color.Red;
            this.lblRge2.Location = new System.Drawing.Point(189, 50);
            this.lblRge2.Name = "lblRge2";
            this.lblRge2.Size = new System.Drawing.Size(117, 13);
            this.lblRge2.TabIndex = 9;
            this.lblRge2.Text = "High-priced Range:";
            // 
            // lblRge1
            // 
            this.lblRge1.AutoSize = true;
            this.lblRge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRge1.ForeColor = System.Drawing.Color.Green;
            this.lblRge1.Location = new System.Drawing.Point(189, 29);
            this.lblRge1.Name = "lblRge1";
            this.lblRge1.Size = new System.Drawing.Size(105, 13);
            this.lblRge1.TabIndex = 8;
            this.lblRge1.Text = "Moderate Range:";
            // 
            // lblMedian
            // 
            this.lblMedian.AutoSize = true;
            this.lblMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedian.Location = new System.Drawing.Point(189, 92);
            this.lblMedian.Name = "lblMedian";
            this.lblMedian.Size = new System.Drawing.Size(52, 13);
            this.lblMedian.TabIndex = 7;
            this.lblMedian.Text = "Median:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(5, 5);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblYrBuilt
            // 
            this.lblYrBuilt.AutoSize = true;
            this.lblYrBuilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYrBuilt.Location = new System.Drawing.Point(5, 92);
            this.lblYrBuilt.Name = "lblYrBuilt";
            this.lblYrBuilt.Size = new System.Drawing.Size(66, 13);
            this.lblYrBuilt.TabIndex = 5;
            this.lblYrBuilt.Text = "Year Built:";
            // 
            // lblSqFt
            // 
            this.lblSqFt.AutoSize = true;
            this.lblSqFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqFt.Location = new System.Drawing.Point(5, 71);
            this.lblSqFt.Name = "lblSqFt";
            this.lblSqFt.Size = new System.Drawing.Size(41, 13);
            this.lblSqFt.TabIndex = 4;
            this.lblSqFt.Text = "Sq Ft:";
            // 
            // lblBath
            // 
            this.lblBath.AutoSize = true;
            this.lblBath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBath.Location = new System.Drawing.Point(5, 50);
            this.lblBath.Name = "lblBath";
            this.lblBath.Size = new System.Drawing.Size(70, 13);
            this.lblBath.TabIndex = 3;
            this.lblBath.Text = "Bathrooms:";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(5, 29);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(66, 13);
            this.lblBed.TabIndex = 2;
            this.lblBed.Text = "Bedrooms:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMax.Location = new System.Drawing.Point(272, 71);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(34, 13);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Max:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMin.Location = new System.Drawing.Point(189, 71);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(31, 13);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "Min:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(138, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 50);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Scraping";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BrowserWindow
            // 
            this.BrowserWindow.Location = new System.Drawing.Point(402, 11);
            this.BrowserWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.BrowserWindow.Name = "BrowserWindow";
            this.BrowserWindow.Size = new System.Drawing.Size(567, 474);
            this.BrowserWindow.TabIndex = 8;
            this.BrowserWindow.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.Location = new System.Drawing.Point(204, 11);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(60, 50);
            this.btnCopyClipboard.TabIndex = 11;
            this.btnCopyClipboard.Text = "Copy Data";
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            this.btnCopyClipboard.Click += new System.EventHandler(this.btnCopyClipboard_Click);
            // 
            // lstRE
            // 
            this.lstRE.FormattingEnabled = true;
            this.lstRE.Location = new System.Drawing.Point(12, 39);
            this.lstRE.Name = "lstRE";
            this.lstRE.Size = new System.Drawing.Size(76, 199);
            this.lstRE.TabIndex = 12;
            // 
            // Foreclosure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 497);
            this.Controls.Add(this.lstRE);
            this.Controls.Add(this.btnCopyClipboard);
            this.Controls.Add(this.BrowserWindow);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel_Results);
            this.Controls.Add(this.lblCOJ);
            this.Name = "Foreclosure";
            this.Text = "Foreclosure Web Scraper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Foreclosure_Resize);
            this.panel_Results.ResumeLayout(false);
            this.panel_Results.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCOJ;
        private System.Windows.Forms.Panel panel_Results;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSqFt;
        private System.Windows.Forms.Label lblBath;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblYrBuilt;
        private System.Windows.Forms.WebBrowser BrowserWindow;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_YrBuilt;
        private System.Windows.Forms.Label lbl_SqFt;
        private System.Windows.Forms.Label lbl_Bath;
        private System.Windows.Forms.Label lbl_Bed;
        private System.Windows.Forms.Label lblRge2;
        private System.Windows.Forms.Label lblRge1;
        private System.Windows.Forms.Label lblMedian;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbl_Rge1;
        private System.Windows.Forms.Label lbl_Median;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Label lbl_Rge2;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.ListBox lstRE;
    }
}

