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
            this.lblRent = new System.Windows.Forms.Label();
            this.lblCOJ = new System.Windows.Forms.Label();
            this.txtCOJURL = new System.Windows.Forms.TextBox();
            this.txtRentURL = new System.Windows.Forms.TextBox();
            this.panel_Results = new System.Windows.Forms.Panel();
            this.lblYrBuilt = new System.Windows.Forms.Label();
            this.lblSqFt = new System.Windows.Forms.Label();
            this.lblBath = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnGetHouseDetails = new System.Windows.Forms.Button();
            this.btnGetRentResults = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Results.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(22, 62);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(88, 13);
            this.lblRent.TabIndex = 0;
            this.lblRent.Text = "Rent Meter URL:";
            // 
            // lblCOJ
            // 
            this.lblCOJ.AutoSize = true;
            this.lblCOJ.Location = new System.Drawing.Point(22, 26);
            this.lblCOJ.Name = "lblCOJ";
            this.lblCOJ.Size = new System.Drawing.Size(55, 13);
            this.lblCOJ.TabIndex = 1;
            this.lblCOJ.Text = "COJ URL:";
            // 
            // txtCOJURL
            // 
            this.txtCOJURL.Location = new System.Drawing.Point(113, 26);
            this.txtCOJURL.MaxLength = 10;
            this.txtCOJURL.Name = "txtCOJURL";
            this.txtCOJURL.Size = new System.Drawing.Size(214, 20);
            this.txtCOJURL.TabIndex = 2;
            // 
            // txtRentURL
            // 
            this.txtRentURL.Location = new System.Drawing.Point(113, 62);
            this.txtRentURL.Name = "txtRentURL";
            this.txtRentURL.Size = new System.Drawing.Size(214, 20);
            this.txtRentURL.TabIndex = 3;
            // 
            // panel_Results
            // 
            this.panel_Results.Controls.Add(this.lblYrBuilt);
            this.panel_Results.Controls.Add(this.lblSqFt);
            this.panel_Results.Controls.Add(this.lblBath);
            this.panel_Results.Controls.Add(this.lblBed);
            this.panel_Results.Controls.Add(this.lblMax);
            this.panel_Results.Controls.Add(this.lblMin);
            this.panel_Results.Location = new System.Drawing.Point(25, 90);
            this.panel_Results.Name = "panel_Results";
            this.panel_Results.Size = new System.Drawing.Size(152, 148);
            this.panel_Results.TabIndex = 4;
            // 
            // lblYrBuilt
            // 
            this.lblYrBuilt.AutoSize = true;
            this.lblYrBuilt.Location = new System.Drawing.Point(10, 125);
            this.lblYrBuilt.Name = "lblYrBuilt";
            this.lblYrBuilt.Size = new System.Drawing.Size(0, 13);
            this.lblYrBuilt.TabIndex = 5;
            // 
            // lblSqFt
            // 
            this.lblSqFt.AutoSize = true;
            this.lblSqFt.Location = new System.Drawing.Point(10, 102);
            this.lblSqFt.Name = "lblSqFt";
            this.lblSqFt.Size = new System.Drawing.Size(0, 13);
            this.lblSqFt.TabIndex = 4;
            // 
            // lblBath
            // 
            this.lblBath.AutoSize = true;
            this.lblBath.Location = new System.Drawing.Point(10, 79);
            this.lblBath.Name = "lblBath";
            this.lblBath.Size = new System.Drawing.Size(0, 13);
            this.lblBath.TabIndex = 3;
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(10, 56);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(0, 13);
            this.lblBed.TabIndex = 2;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(10, 33);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(0, 13);
            this.lblMax.TabIndex = 1;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(10, 10);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(0, 13);
            this.lblMin.TabIndex = 0;
            // 
            // btnGetHouseDetails
            // 
            this.btnGetHouseDetails.Location = new System.Drawing.Point(183, 90);
            this.btnGetHouseDetails.Name = "btnGetHouseDetails";
            this.btnGetHouseDetails.Size = new System.Drawing.Size(69, 47);
            this.btnGetHouseDetails.TabIndex = 5;
            this.btnGetHouseDetails.Text = "Get House Details";
            this.btnGetHouseDetails.UseVisualStyleBackColor = true;
            this.btnGetHouseDetails.Click += new System.EventHandler(this.btnGetHouseDetails_Click);
            // 
            // btnGetRentResults
            // 
            this.btnGetRentResults.Location = new System.Drawing.Point(258, 90);
            this.btnGetRentResults.Name = "btnGetRentResults";
            this.btnGetRentResults.Size = new System.Drawing.Size(69, 47);
            this.btnGetRentResults.TabIndex = 6;
            this.btnGetRentResults.Text = "Get Rent Details";
            this.btnGetRentResults.UseVisualStyleBackColor = true;
            this.btnGetRentResults.Click += new System.EventHandler(this.btnGetRentResults_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Foreclosure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetRentResults);
            this.Controls.Add(this.btnGetHouseDetails);
            this.Controls.Add(this.panel_Results);
            this.Controls.Add(this.txtRentURL);
            this.Controls.Add(this.txtCOJURL);
            this.Controls.Add(this.lblCOJ);
            this.Controls.Add(this.lblRent);
            this.Name = "Foreclosure";
            this.Text = "Form1";
            this.panel_Results.ResumeLayout(false);
            this.panel_Results.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblCOJ;
        private System.Windows.Forms.TextBox txtCOJURL;
        private System.Windows.Forms.TextBox txtRentURL;
        private System.Windows.Forms.Panel panel_Results;
        private System.Windows.Forms.Button btnGetHouseDetails;
        private System.Windows.Forms.Label lblSqFt;
        private System.Windows.Forms.Label lblBath;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblYrBuilt;
        private System.Windows.Forms.Button btnGetRentResults;
        private System.Windows.Forms.Button button1;
    }
}

