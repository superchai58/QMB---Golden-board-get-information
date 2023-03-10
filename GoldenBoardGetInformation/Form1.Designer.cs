namespace GoldenBoardGetInformation
{
    partial class frmGoldenBoardGetInformation
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
            this.lbSN = new System.Windows.Forms.Label();
            this.rdoSN = new System.Windows.Forms.RadioButton();
            this.rdoExcel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbLoad = new System.Windows.Forms.PictureBox();
            this.bgwSNScan = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.bgwExcelUpload = new System.ComponentModel.BackgroundWorker();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSN
            // 
            this.lbSN.AutoSize = true;
            this.lbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSN.Location = new System.Drawing.Point(16, 17);
            this.lbSN.Name = "lbSN";
            this.lbSN.Size = new System.Drawing.Size(31, 20);
            this.lbSN.TabIndex = 0;
            this.lbSN.Text = "SN";
            // 
            // rdoSN
            // 
            this.rdoSN.AutoSize = true;
            this.rdoSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSN.Location = new System.Drawing.Point(12, 12);
            this.rdoSN.Name = "rdoSN";
            this.rdoSN.Size = new System.Drawing.Size(123, 24);
            this.rdoSN.TabIndex = 1;
            this.rdoSN.TabStop = true;
            this.rdoSN.Text = "SerialNumber";
            this.rdoSN.UseVisualStyleBackColor = true;
            this.rdoSN.CheckedChanged += new System.EventHandler(this.rdoSN_CheckedChanged);
            // 
            // rdoExcel
            // 
            this.rdoExcel.AutoSize = true;
            this.rdoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoExcel.Location = new System.Drawing.Point(141, 12);
            this.rdoExcel.Name = "rdoExcel";
            this.rdoExcel.Size = new System.Drawing.Size(65, 24);
            this.rdoExcel.TabIndex = 2;
            this.rdoExcel.TabStop = true;
            this.rdoExcel.Text = "Excel";
            this.rdoExcel.UseVisualStyleBackColor = true;
            this.rdoExcel.CheckedChanged += new System.EventHandler(this.rdoExcel_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warning !!!";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Excel upload:\r\nSeetName = GoldenBoard\r\nHead column  = SN\r\nFIle type = .xls";
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(49, 14);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(213, 26);
            this.txtSN.TabIndex = 4;
            this.txtSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSN_KeyDown);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(20, 52);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(242, 26);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload excel file click here";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtSN);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.lbSN);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 98);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pcbLoad);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(318, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 238);
            this.panel2.TabIndex = 8;
            // 
            // pcbLoad
            // 
            this.pcbLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLoad.Image = global::GoldenBoardGetInformation.Properties.Resources.giphy;
            this.pcbLoad.Location = new System.Drawing.Point(0, 82);
            this.pcbLoad.Name = "pcbLoad";
            this.pcbLoad.Size = new System.Drawing.Size(146, 156);
            this.pcbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLoad.TabIndex = 4;
            this.pcbLoad.TabStop = false;
            // 
            // bgwSNScan
            // 
            this.bgwSNScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSNScan_DoWork);
            this.bgwSNScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSNScan_RunWorkerCompleted);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lbResult);
            this.panel3.Location = new System.Drawing.Point(12, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 80);
            this.panel3.TabIndex = 9;
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(10, 9);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(269, 67);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "";
            // 
            // bgwExcelUpload
            // 
            this.bgwExcelUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExcelUpload_DoWork);
            this.bgwExcelUpload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExcelUpload_RunWorkerCompleted);
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "ofdExcel";
            // 
            // frmGoldenBoardGetInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(464, 238);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoExcel);
            this.Controls.Add(this.rdoSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGoldenBoardGetInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoldenBoardGetInformation [20230201]";
            this.Load += new System.EventHandler(this.frmGoldenBoardGetInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSN;
        private System.Windows.Forms.RadioButton rdoSN;
        private System.Windows.Forms.RadioButton rdoExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbLoad;
        private System.ComponentModel.BackgroundWorker bgwSNScan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbResult;
        private System.ComponentModel.BackgroundWorker bgwExcelUpload;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
    }
}

