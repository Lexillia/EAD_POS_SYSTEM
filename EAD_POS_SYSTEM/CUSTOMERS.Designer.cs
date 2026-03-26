namespace EAD_POS_SYSTEM
{
    partial class CUSTOMERS
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
            this.lblCustomers = new System.Windows.Forms.Label();
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnSC = new System.Windows.Forms.Button();
            this.txtSsubtitle = new System.Windows.Forms.TextBox();
            this.txtSearchCM = new System.Windows.Forms.TextBox();
            this.lblsubtitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotalCustomers = new System.Windows.Forms.Panel();
            this.lblTSamount = new System.Windows.Forms.Label();
            this.lbCStxt = new System.Windows.Forms.Label();
            this.pnlTotalCreditExtended = new System.Windows.Forms.Panel();
            this.lblTCEamount = new System.Windows.Forms.Label();
            this.lblTCEtxt = new System.Windows.Forms.Label();
            this.pnlCustomersNearLimit = new System.Windows.Forms.Panel();
            this.lblCNLamount = new System.Windows.Forms.Label();
            this.lblCNLtxt = new System.Windows.Forms.Label();
            this.pnlmaincontainer = new System.Windows.Forms.Panel();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlTotalCustomers.SuspendLayout();
            this.pnlTotalCreditExtended.SuspendLayout();
            this.pnlCustomersNearLimit.SuspendLayout();
            this.pnlmaincontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(12, 19);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(197, 31);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "CUSTOMERS";
            // 
            // pnltop
            // 
            this.pnltop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnltop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnltop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnltop.Controls.Add(this.btnAC);
            this.pnltop.Controls.Add(this.btnSC);
            this.pnltop.Controls.Add(this.txtSsubtitle);
            this.pnltop.Controls.Add(this.txtSearchCM);
            this.pnltop.Controls.Add(this.lblCustomers);
            this.pnltop.Controls.Add(this.lblsubtitle);
            this.pnltop.Location = new System.Drawing.Point(1, 39);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(875, 187);
            this.pnltop.TabIndex = 1;
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.Black;
            this.btnAC.ForeColor = System.Drawing.Color.White;
            this.btnAC.Location = new System.Drawing.Point(18, 153);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(129, 31);
            this.btnAC.TabIndex = 15;
            this.btnAC.Text = "Add Customer";
            this.btnAC.UseVisualStyleBackColor = false;
            // 
            // btnSC
            // 
            this.btnSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSC.Location = new System.Drawing.Point(628, 107);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(75, 23);
            this.btnSC.TabIndex = 9;
            this.btnSC.Text = "&Search";
            this.btnSC.UseVisualStyleBackColor = true;
            // 
            // txtSsubtitle
            // 
            this.txtSsubtitle.BackColor = System.Drawing.Color.Black;
            this.txtSsubtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSsubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSsubtitle.ForeColor = System.Drawing.Color.White;
            this.txtSsubtitle.Location = new System.Drawing.Point(18, 90);
            this.txtSsubtitle.Name = "txtSsubtitle";
            this.txtSsubtitle.Size = new System.Drawing.Size(180, 13);
            this.txtSsubtitle.TabIndex = 8;
            this.txtSsubtitle.Text = "Search by name, phone or email...";
            // 
            // txtSearchCM
            // 
            this.txtSearchCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCM.Location = new System.Drawing.Point(18, 109);
            this.txtSearchCM.Name = "txtSearchCM";
            this.txtSearchCM.Size = new System.Drawing.Size(429, 21);
            this.txtSearchCM.TabIndex = 5;
            // 
            // lblsubtitle
            // 
            this.lblsubtitle.AutoSize = true;
            this.lblsubtitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsubtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitle.ForeColor = System.Drawing.Color.White;
            this.lblsubtitle.Location = new System.Drawing.Point(18, 50);
            this.lblsubtitle.Name = "lblsubtitle";
            this.lblsubtitle.Size = new System.Drawing.Size(304, 18);
            this.lblsubtitle.TabIndex = 4;
            this.lblsubtitle.Text = "Manage customer accounts and credit information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(113, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 240);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Credit Limit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Balance";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // pnlTotalCustomers
            // 
            this.pnlTotalCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTotalCustomers.Controls.Add(this.lblTSamount);
            this.pnlTotalCustomers.Controls.Add(this.lbCStxt);
            this.pnlTotalCustomers.Location = new System.Drawing.Point(20, 291);
            this.pnlTotalCustomers.Name = "pnlTotalCustomers";
            this.pnlTotalCustomers.Size = new System.Drawing.Size(191, 123);
            this.pnlTotalCustomers.TabIndex = 4;
            // 
            // lblTSamount
            // 
            this.lblTSamount.AutoSize = true;
            this.lblTSamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTSamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSamount.ForeColor = System.Drawing.Color.White;
            this.lblTSamount.Location = new System.Drawing.Point(12, 74);
            this.lblTSamount.Name = "lblTSamount";
            this.lblTSamount.Size = new System.Drawing.Size(29, 31);
            this.lblTSamount.TabIndex = 11;
            this.lblTSamount.Text = "0";
            // 
            // lbCStxt
            // 
            this.lbCStxt.AutoSize = true;
            this.lbCStxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCStxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCStxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCStxt.ForeColor = System.Drawing.Color.White;
            this.lbCStxt.Location = new System.Drawing.Point(3, 31);
            this.lbCStxt.Name = "lbCStxt";
            this.lbCStxt.Size = new System.Drawing.Size(156, 17);
            this.lbCStxt.TabIndex = 10;
            this.lbCStxt.Text = "TODAY\'S CUSTOMERS";
            // 
            // pnlTotalCreditExtended
            // 
            this.pnlTotalCreditExtended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTotalCreditExtended.Controls.Add(this.lblTCEamount);
            this.pnlTotalCreditExtended.Controls.Add(this.lblTCEtxt);
            this.pnlTotalCreditExtended.Location = new System.Drawing.Point(338, 294);
            this.pnlTotalCreditExtended.Name = "pnlTotalCreditExtended";
            this.pnlTotalCreditExtended.Size = new System.Drawing.Size(191, 123);
            this.pnlTotalCreditExtended.TabIndex = 5;
            // 
            // lblTCEamount
            // 
            this.lblTCEamount.AutoSize = true;
            this.lblTCEamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTCEamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCEamount.ForeColor = System.Drawing.Color.White;
            this.lblTCEamount.Location = new System.Drawing.Point(12, 74);
            this.lblTCEamount.Name = "lblTCEamount";
            this.lblTCEamount.Size = new System.Drawing.Size(43, 31);
            this.lblTCEamount.TabIndex = 11;
            this.lblTCEamount.Text = "$0";
            // 
            // lblTCEtxt
            // 
            this.lblTCEtxt.AutoSize = true;
            this.lblTCEtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTCEtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTCEtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCEtxt.ForeColor = System.Drawing.Color.White;
            this.lblTCEtxt.Location = new System.Drawing.Point(3, 31);
            this.lblTCEtxt.Name = "lblTCEtxt";
            this.lblTCEtxt.Size = new System.Drawing.Size(183, 17);
            this.lblTCEtxt.TabIndex = 10;
            this.lblTCEtxt.Text = "TOTAL CREDIT EXTENDED";
            // 
            // pnlCustomersNearLimit
            // 
            this.pnlCustomersNearLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCustomersNearLimit.Controls.Add(this.lblCNLamount);
            this.pnlCustomersNearLimit.Controls.Add(this.lblCNLtxt);
            this.pnlCustomersNearLimit.Location = new System.Drawing.Point(662, 291);
            this.pnlCustomersNearLimit.Name = "pnlCustomersNearLimit";
            this.pnlCustomersNearLimit.Size = new System.Drawing.Size(191, 123);
            this.pnlCustomersNearLimit.TabIndex = 7;
            // 
            // lblCNLamount
            // 
            this.lblCNLamount.AutoSize = true;
            this.lblCNLamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCNLamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNLamount.ForeColor = System.Drawing.Color.White;
            this.lblCNLamount.Location = new System.Drawing.Point(12, 74);
            this.lblCNLamount.Name = "lblCNLamount";
            this.lblCNLamount.Size = new System.Drawing.Size(29, 31);
            this.lblCNLamount.TabIndex = 11;
            this.lblCNLamount.Text = "0";
            // 
            // lblCNLtxt
            // 
            this.lblCNLtxt.AutoSize = true;
            this.lblCNLtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCNLtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCNLtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNLtxt.ForeColor = System.Drawing.Color.White;
            this.lblCNLtxt.Location = new System.Drawing.Point(3, 31);
            this.lblCNLtxt.Name = "lblCNLtxt";
            this.lblCNLtxt.Size = new System.Drawing.Size(176, 17);
            this.lblCNLtxt.TabIndex = 10;
            this.lblCNLtxt.Text = "CUSTOMERS NEAR LIMIT";
            // 
            // pnlmaincontainer
            // 
            this.pnlmaincontainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlmaincontainer.AutoScroll = true;
            this.pnlmaincontainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlmaincontainer.Controls.Add(this.pnlCustomersNearLimit);
            this.pnlmaincontainer.Controls.Add(this.dataGridView1);
            this.pnlmaincontainer.Controls.Add(this.pnlTotalCreditExtended);
            this.pnlmaincontainer.Controls.Add(this.pnlTotalCustomers);
            this.pnlmaincontainer.Location = new System.Drawing.Point(1, 232);
            this.pnlmaincontainer.Name = "pnlmaincontainer";
            this.pnlmaincontainer.Size = new System.Drawing.Size(875, 432);
            this.pnlmaincontainer.TabIndex = 8;
            // 
            // CUSTOMERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(881, 659);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlmaincontainer);
            this.Name = "CUSTOMERS";
            this.Text = "CUSTOMERS";
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlTotalCustomers.ResumeLayout(false);
            this.pnlTotalCustomers.PerformLayout();
            this.pnlTotalCreditExtended.ResumeLayout(false);
            this.pnlTotalCreditExtended.PerformLayout();
            this.pnlCustomersNearLimit.ResumeLayout(false);
            this.pnlCustomersNearLimit.PerformLayout();
            this.pnlmaincontainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblsubtitle;
        private System.Windows.Forms.TextBox txtSearchCM;
        private System.Windows.Forms.TextBox txtSsubtitle;
        private System.Windows.Forms.Button btnSC;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel pnlTotalCustomers;
        private System.Windows.Forms.Label lblTSamount;
        private System.Windows.Forms.Label lbCStxt;
        private System.Windows.Forms.Panel pnlTotalCreditExtended;
        private System.Windows.Forms.Label lblTCEamount;
        private System.Windows.Forms.Label lblTCEtxt;
        private System.Windows.Forms.Panel pnlCustomersNearLimit;
        private System.Windows.Forms.Label lblCNLamount;
        private System.Windows.Forms.Label lblCNLtxt;
        private System.Windows.Forms.Panel pnlmaincontainer;
    }
}