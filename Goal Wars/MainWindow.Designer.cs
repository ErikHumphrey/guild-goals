namespace Guild_Goals
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pboCurrencyIcon1 = new System.Windows.Forms.PictureBox();
            this.lblCurrencyName1 = new System.Windows.Forms.Label();
            this.prgCurrency1 = new System.Windows.Forms.ProgressBar();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCurrencyCount1 = new System.Windows.Forms.Label();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.pnlCurrency1 = new System.Windows.Forms.Panel();
            this.pnlCurrency2 = new System.Windows.Forms.Panel();
            this.prgCurrency2 = new System.Windows.Forms.ProgressBar();
            this.lblCurrencyCount2 = new System.Windows.Forms.Label();
            this.pboCurrencyIcon2 = new System.Windows.Forms.PictureBox();
            this.lblCurrencyName2 = new System.Windows.Forms.Label();
            this.pnlCurrency3 = new System.Windows.Forms.Panel();
            this.prgCurrency3 = new System.Windows.Forms.ProgressBar();
            this.lblCurrencyCount3 = new System.Windows.Forms.Label();
            this.pboCurrencyIcon3 = new System.Windows.Forms.PictureBox();
            this.lblCurrencyName3 = new System.Windows.Forms.Label();
            this.pnlCurrency4 = new System.Windows.Forms.Panel();
            this.prgCurrency4 = new System.Windows.Forms.ProgressBar();
            this.lblCurrencyCount4 = new System.Windows.Forms.Label();
            this.pboCurrencyIcon4 = new System.Windows.Forms.PictureBox();
            this.lblCurrencyName4 = new System.Windows.Forms.Label();
            this.pnlCurrency5 = new System.Windows.Forms.Panel();
            this.prgCurrency5 = new System.Windows.Forms.ProgressBar();
            this.lblCurrencyCount5 = new System.Windows.Forms.Label();
            this.pboCurrencyIcon5 = new System.Windows.Forms.PictureBox();
            this.lblCurrencyName5 = new System.Windows.Forms.Label();
            this.pnlCurrency6 = new System.Windows.Forms.Panel();
            this.prgCurrency6 = new System.Windows.Forms.ProgressBar();
            this.lblCurrencyCount6 = new System.Windows.Forms.Label();
            this.pboCurrencyIcon6 = new System.Windows.Forms.PictureBox();
            this.lblCurrencyName6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon1)).BeginInit();
            this.pnlCurrency1.SuspendLayout();
            this.pnlCurrency2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon2)).BeginInit();
            this.pnlCurrency3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon3)).BeginInit();
            this.pnlCurrency4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon4)).BeginInit();
            this.pnlCurrency5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon5)).BeginInit();
            this.pnlCurrency6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon6)).BeginInit();
            this.SuspendLayout();
            // 
            // pboCurrencyIcon1
            // 
            this.pboCurrencyIcon1.Location = new System.Drawing.Point(8, 10);
            this.pboCurrencyIcon1.Name = "pboCurrencyIcon1";
            this.pboCurrencyIcon1.Size = new System.Drawing.Size(50, 50);
            this.pboCurrencyIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCurrencyIcon1.TabIndex = 0;
            this.pboCurrencyIcon1.TabStop = false;
            // 
            // lblCurrencyName1
            // 
            this.lblCurrencyName1.AutoSize = true;
            this.lblCurrencyName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName1.Location = new System.Drawing.Point(64, 13);
            this.lblCurrencyName1.Name = "lblCurrencyName1";
            this.lblCurrencyName1.Size = new System.Drawing.Size(168, 20);
            this.lblCurrencyName1.TabIndex = 1;
            this.lblCurrencyName1.Text = "Undefined Currency";
            // 
            // prgCurrency1
            // 
            this.prgCurrency1.Location = new System.Drawing.Point(67, 37);
            this.prgCurrency1.Name = "prgCurrency1";
            this.prgCurrency1.Size = new System.Drawing.Size(362, 23);
            this.prgCurrency1.TabIndex = 2;
            // 
            // txtApiKey
            // 
            this.txtApiKey.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApiKey.Location = new System.Drawing.Point(10, 8);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(445, 20);
            this.txtApiKey.TabIndex = 5;
            this.txtApiKey.Text = "Enter your Guild Wars 2 API key";
            this.txtApiKey.TextChanged += new System.EventHandler(this.TxtApiKey_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(461, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblCurrencyCount1
            // 
            this.lblCurrencyCount1.Location = new System.Drawing.Point(316, 20);
            this.lblCurrencyCount1.Name = "lblCurrencyCount1";
            this.lblCurrencyCount1.Size = new System.Drawing.Size(113, 13);
            this.lblCurrencyCount1.TabIndex = 5;
            this.lblCurrencyCount1.Text = "0 / 0";
            this.lblCurrencyCount1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 2;
            this.tmrCounter.Tick += new System.EventHandler(this.TmrCounter_Tick);
            // 
            // pnlCurrency1
            // 
            this.pnlCurrency1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrency1.Controls.Add(this.prgCurrency1);
            this.pnlCurrency1.Controls.Add(this.lblCurrencyCount1);
            this.pnlCurrency1.Controls.Add(this.pboCurrencyIcon1);
            this.pnlCurrency1.Controls.Add(this.lblCurrencyName1);
            this.pnlCurrency1.Location = new System.Drawing.Point(55, 54);
            this.pnlCurrency1.Name = "pnlCurrency1";
            this.pnlCurrency1.Size = new System.Drawing.Size(436, 70);
            this.pnlCurrency1.TabIndex = 6;
            // 
            // pnlCurrency2
            // 
            this.pnlCurrency2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrency2.Controls.Add(this.prgCurrency2);
            this.pnlCurrency2.Controls.Add(this.lblCurrencyCount2);
            this.pnlCurrency2.Controls.Add(this.pboCurrencyIcon2);
            this.pnlCurrency2.Controls.Add(this.lblCurrencyName2);
            this.pnlCurrency2.Location = new System.Drawing.Point(55, 130);
            this.pnlCurrency2.Name = "pnlCurrency2";
            this.pnlCurrency2.Size = new System.Drawing.Size(436, 70);
            this.pnlCurrency2.TabIndex = 7;
            // 
            // prgCurrency2
            // 
            this.prgCurrency2.Location = new System.Drawing.Point(67, 37);
            this.prgCurrency2.Name = "prgCurrency2";
            this.prgCurrency2.Size = new System.Drawing.Size(362, 23);
            this.prgCurrency2.TabIndex = 2;
            // 
            // lblCurrencyCount2
            // 
            this.lblCurrencyCount2.Location = new System.Drawing.Point(313, 20);
            this.lblCurrencyCount2.Name = "lblCurrencyCount2";
            this.lblCurrencyCount2.Size = new System.Drawing.Size(116, 13);
            this.lblCurrencyCount2.TabIndex = 5;
            this.lblCurrencyCount2.Text = "0 / 0";
            this.lblCurrencyCount2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pboCurrencyIcon2
            // 
            this.pboCurrencyIcon2.Location = new System.Drawing.Point(8, 10);
            this.pboCurrencyIcon2.Name = "pboCurrencyIcon2";
            this.pboCurrencyIcon2.Size = new System.Drawing.Size(50, 50);
            this.pboCurrencyIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCurrencyIcon2.TabIndex = 0;
            this.pboCurrencyIcon2.TabStop = false;
            // 
            // lblCurrencyName2
            // 
            this.lblCurrencyName2.AutoSize = true;
            this.lblCurrencyName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName2.Location = new System.Drawing.Point(64, 13);
            this.lblCurrencyName2.Name = "lblCurrencyName2";
            this.lblCurrencyName2.Size = new System.Drawing.Size(168, 20);
            this.lblCurrencyName2.TabIndex = 1;
            this.lblCurrencyName2.Text = "Undefined Currency";
            // 
            // pnlCurrency3
            // 
            this.pnlCurrency3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrency3.Controls.Add(this.prgCurrency3);
            this.pnlCurrency3.Controls.Add(this.lblCurrencyCount3);
            this.pnlCurrency3.Controls.Add(this.pboCurrencyIcon3);
            this.pnlCurrency3.Controls.Add(this.lblCurrencyName3);
            this.pnlCurrency3.Location = new System.Drawing.Point(55, 206);
            this.pnlCurrency3.Name = "pnlCurrency3";
            this.pnlCurrency3.Size = new System.Drawing.Size(436, 70);
            this.pnlCurrency3.TabIndex = 8;
            // 
            // prgCurrency3
            // 
            this.prgCurrency3.Location = new System.Drawing.Point(67, 37);
            this.prgCurrency3.Name = "prgCurrency3";
            this.prgCurrency3.Size = new System.Drawing.Size(362, 23);
            this.prgCurrency3.TabIndex = 2;
            // 
            // lblCurrencyCount3
            // 
            this.lblCurrencyCount3.Location = new System.Drawing.Point(310, 20);
            this.lblCurrencyCount3.Name = "lblCurrencyCount3";
            this.lblCurrencyCount3.Size = new System.Drawing.Size(119, 13);
            this.lblCurrencyCount3.TabIndex = 5;
            this.lblCurrencyCount3.Text = "0 / 0";
            this.lblCurrencyCount3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pboCurrencyIcon3
            // 
            this.pboCurrencyIcon3.Location = new System.Drawing.Point(8, 10);
            this.pboCurrencyIcon3.Name = "pboCurrencyIcon3";
            this.pboCurrencyIcon3.Size = new System.Drawing.Size(50, 50);
            this.pboCurrencyIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCurrencyIcon3.TabIndex = 0;
            this.pboCurrencyIcon3.TabStop = false;
            // 
            // lblCurrencyName3
            // 
            this.lblCurrencyName3.AutoSize = true;
            this.lblCurrencyName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName3.Location = new System.Drawing.Point(64, 13);
            this.lblCurrencyName3.Name = "lblCurrencyName3";
            this.lblCurrencyName3.Size = new System.Drawing.Size(168, 20);
            this.lblCurrencyName3.TabIndex = 1;
            this.lblCurrencyName3.Text = "Undefined Currency";
            // 
            // pnlCurrency4
            // 
            this.pnlCurrency4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrency4.Controls.Add(this.prgCurrency4);
            this.pnlCurrency4.Controls.Add(this.lblCurrencyCount4);
            this.pnlCurrency4.Controls.Add(this.pboCurrencyIcon4);
            this.pnlCurrency4.Controls.Add(this.lblCurrencyName4);
            this.pnlCurrency4.Location = new System.Drawing.Point(55, 282);
            this.pnlCurrency4.Name = "pnlCurrency4";
            this.pnlCurrency4.Size = new System.Drawing.Size(436, 70);
            this.pnlCurrency4.TabIndex = 9;
            // 
            // prgCurrency4
            // 
            this.prgCurrency4.Location = new System.Drawing.Point(67, 37);
            this.prgCurrency4.Name = "prgCurrency4";
            this.prgCurrency4.Size = new System.Drawing.Size(362, 23);
            this.prgCurrency4.TabIndex = 2;
            // 
            // lblCurrencyCount4
            // 
            this.lblCurrencyCount4.Location = new System.Drawing.Point(307, 20);
            this.lblCurrencyCount4.Name = "lblCurrencyCount4";
            this.lblCurrencyCount4.Size = new System.Drawing.Size(122, 13);
            this.lblCurrencyCount4.TabIndex = 5;
            this.lblCurrencyCount4.Text = "0 / 0";
            this.lblCurrencyCount4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pboCurrencyIcon4
            // 
            this.pboCurrencyIcon4.Location = new System.Drawing.Point(8, 10);
            this.pboCurrencyIcon4.Name = "pboCurrencyIcon4";
            this.pboCurrencyIcon4.Size = new System.Drawing.Size(50, 50);
            this.pboCurrencyIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCurrencyIcon4.TabIndex = 0;
            this.pboCurrencyIcon4.TabStop = false;
            // 
            // lblCurrencyName4
            // 
            this.lblCurrencyName4.AutoSize = true;
            this.lblCurrencyName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName4.Location = new System.Drawing.Point(64, 13);
            this.lblCurrencyName4.Name = "lblCurrencyName4";
            this.lblCurrencyName4.Size = new System.Drawing.Size(168, 20);
            this.lblCurrencyName4.TabIndex = 1;
            this.lblCurrencyName4.Text = "Undefined Currency";
            // 
            // pnlCurrency5
            // 
            this.pnlCurrency5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrency5.Controls.Add(this.prgCurrency5);
            this.pnlCurrency5.Controls.Add(this.lblCurrencyCount5);
            this.pnlCurrency5.Controls.Add(this.pboCurrencyIcon5);
            this.pnlCurrency5.Controls.Add(this.lblCurrencyName5);
            this.pnlCurrency5.Location = new System.Drawing.Point(55, 358);
            this.pnlCurrency5.Name = "pnlCurrency5";
            this.pnlCurrency5.Size = new System.Drawing.Size(436, 70);
            this.pnlCurrency5.TabIndex = 10;
            // 
            // prgCurrency5
            // 
            this.prgCurrency5.Location = new System.Drawing.Point(67, 37);
            this.prgCurrency5.Name = "prgCurrency5";
            this.prgCurrency5.Size = new System.Drawing.Size(362, 23);
            this.prgCurrency5.TabIndex = 2;
            // 
            // lblCurrencyCount5
            // 
            this.lblCurrencyCount5.Location = new System.Drawing.Point(307, 20);
            this.lblCurrencyCount5.Name = "lblCurrencyCount5";
            this.lblCurrencyCount5.Size = new System.Drawing.Size(122, 13);
            this.lblCurrencyCount5.TabIndex = 5;
            this.lblCurrencyCount5.Text = "0 / 0";
            this.lblCurrencyCount5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pboCurrencyIcon5
            // 
            this.pboCurrencyIcon5.Location = new System.Drawing.Point(8, 10);
            this.pboCurrencyIcon5.Name = "pboCurrencyIcon5";
            this.pboCurrencyIcon5.Size = new System.Drawing.Size(50, 50);
            this.pboCurrencyIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCurrencyIcon5.TabIndex = 0;
            this.pboCurrencyIcon5.TabStop = false;
            // 
            // lblCurrencyName5
            // 
            this.lblCurrencyName5.AutoSize = true;
            this.lblCurrencyName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName5.Location = new System.Drawing.Point(64, 13);
            this.lblCurrencyName5.Name = "lblCurrencyName5";
            this.lblCurrencyName5.Size = new System.Drawing.Size(168, 20);
            this.lblCurrencyName5.TabIndex = 1;
            this.lblCurrencyName5.Text = "Undefined Currency";
            // 
            // pnlCurrency6
            // 
            this.pnlCurrency6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrency6.Controls.Add(this.prgCurrency6);
            this.pnlCurrency6.Controls.Add(this.lblCurrencyCount6);
            this.pnlCurrency6.Controls.Add(this.pboCurrencyIcon6);
            this.pnlCurrency6.Controls.Add(this.lblCurrencyName6);
            this.pnlCurrency6.Location = new System.Drawing.Point(55, 434);
            this.pnlCurrency6.Name = "pnlCurrency6";
            this.pnlCurrency6.Size = new System.Drawing.Size(436, 70);
            this.pnlCurrency6.TabIndex = 11;
            // 
            // prgCurrency6
            // 
            this.prgCurrency6.Location = new System.Drawing.Point(67, 37);
            this.prgCurrency6.Name = "prgCurrency6";
            this.prgCurrency6.Size = new System.Drawing.Size(362, 23);
            this.prgCurrency6.TabIndex = 2;
            // 
            // lblCurrencyCount6
            // 
            this.lblCurrencyCount6.Location = new System.Drawing.Point(304, 20);
            this.lblCurrencyCount6.Name = "lblCurrencyCount6";
            this.lblCurrencyCount6.Size = new System.Drawing.Size(125, 13);
            this.lblCurrencyCount6.TabIndex = 5;
            this.lblCurrencyCount6.Text = "0 / 0";
            this.lblCurrencyCount6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pboCurrencyIcon6
            // 
            this.pboCurrencyIcon6.Location = new System.Drawing.Point(8, 10);
            this.pboCurrencyIcon6.Name = "pboCurrencyIcon6";
            this.pboCurrencyIcon6.Size = new System.Drawing.Size(50, 50);
            this.pboCurrencyIcon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCurrencyIcon6.TabIndex = 0;
            this.pboCurrencyIcon6.TabStop = false;
            // 
            // lblCurrencyName6
            // 
            this.lblCurrencyName6.AutoSize = true;
            this.lblCurrencyName6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyName6.Location = new System.Drawing.Point(64, 13);
            this.lblCurrencyName6.Name = "lblCurrencyName6";
            this.lblCurrencyName6.Size = new System.Drawing.Size(168, 20);
            this.lblCurrencyName6.TabIndex = 1;
            this.lblCurrencyName6.Text = "Undefined Currency";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 540);
            this.Controls.Add(this.pnlCurrency6);
            this.Controls.Add(this.pnlCurrency5);
            this.Controls.Add(this.pnlCurrency4);
            this.Controls.Add(this.pnlCurrency3);
            this.Controls.Add(this.pnlCurrency2);
            this.Controls.Add(this.pnlCurrency1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtApiKey);
            this.Name = "frmMain";
            this.Text = "Guild Goals";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon1)).EndInit();
            this.pnlCurrency1.ResumeLayout(false);
            this.pnlCurrency1.PerformLayout();
            this.pnlCurrency2.ResumeLayout(false);
            this.pnlCurrency2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon2)).EndInit();
            this.pnlCurrency3.ResumeLayout(false);
            this.pnlCurrency3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon3)).EndInit();
            this.pnlCurrency4.ResumeLayout(false);
            this.pnlCurrency4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon4)).EndInit();
            this.pnlCurrency5.ResumeLayout(false);
            this.pnlCurrency5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon5)).EndInit();
            this.pnlCurrency6.ResumeLayout(false);
            this.pnlCurrency6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCurrencyIcon6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboCurrencyIcon1;
        private System.Windows.Forms.Label lblCurrencyName1;
        private System.Windows.Forms.ProgressBar prgCurrency1;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCurrencyCount1;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.Panel pnlCurrency1;
        private System.Windows.Forms.Panel pnlCurrency2;
        private System.Windows.Forms.ProgressBar prgCurrency2;
        private System.Windows.Forms.Label lblCurrencyCount2;
        private System.Windows.Forms.PictureBox pboCurrencyIcon2;
        private System.Windows.Forms.Label lblCurrencyName2;
        private System.Windows.Forms.Panel pnlCurrency3;
        private System.Windows.Forms.ProgressBar prgCurrency3;
        private System.Windows.Forms.Label lblCurrencyCount3;
        private System.Windows.Forms.PictureBox pboCurrencyIcon3;
        private System.Windows.Forms.Label lblCurrencyName3;
        private System.Windows.Forms.Panel pnlCurrency4;
        private System.Windows.Forms.ProgressBar prgCurrency4;
        private System.Windows.Forms.Label lblCurrencyCount4;
        private System.Windows.Forms.PictureBox pboCurrencyIcon4;
        private System.Windows.Forms.Label lblCurrencyName4;
        private System.Windows.Forms.Panel pnlCurrency5;
        private System.Windows.Forms.ProgressBar prgCurrency5;
        private System.Windows.Forms.Label lblCurrencyCount5;
        private System.Windows.Forms.PictureBox pboCurrencyIcon5;
        private System.Windows.Forms.Label lblCurrencyName5;
        private System.Windows.Forms.Panel pnlCurrency6;
        private System.Windows.Forms.ProgressBar prgCurrency6;
        private System.Windows.Forms.Label lblCurrencyCount6;
        private System.Windows.Forms.PictureBox pboCurrencyIcon6;
        private System.Windows.Forms.Label lblCurrencyName6;
    }
}

