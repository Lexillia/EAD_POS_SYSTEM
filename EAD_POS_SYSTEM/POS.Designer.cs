namespace EAD_POS_SYSTEM
{
    partial class POS
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
            this.pnltop = new System.Windows.Forms.Panel();
            this.lblPOS = new System.Windows.Forms.Label();
            this.btnSP = new System.Windows.Forms.Button();
            this.txtSsubtitle = new System.Windows.Forms.TextBox();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.lblsubtitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.pnlReceipt = new System.Windows.Forms.Panel();
            this.txtSubtitle2 = new System.Windows.Forms.TextBox();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.lblTotalamount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnltop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.pnlReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnltop.BackColor = System.Drawing.Color.Black;
            this.pnltop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnltop.Controls.Add(this.lblPOS);
            this.pnltop.Controls.Add(this.btnSP);
            this.pnltop.Controls.Add(this.txtSsubtitle);
            this.pnltop.Controls.Add(this.txtSearchProducts);
            this.pnltop.Controls.Add(this.lblsubtitle);
            this.pnltop.Location = new System.Drawing.Point(26, 70);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(544, 146);
            this.pnltop.TabIndex = 1;
            // 
            // lblPOS
            // 
            this.lblPOS.AutoSize = true;
            this.lblPOS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOS.ForeColor = System.Drawing.Color.White;
            this.lblPOS.Location = new System.Drawing.Point(10, 4);
            this.lblPOS.Name = "lblPOS";
            this.lblPOS.Size = new System.Drawing.Size(234, 33);
            this.lblPOS.TabIndex = 4;
            this.lblPOS.Text = "POINT OF SALE";
            // 
            // btnSP
            // 
            this.btnSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSP.Location = new System.Drawing.Point(415, 107);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(75, 23);
            this.btnSP.TabIndex = 6;
            this.btnSP.Text = "&Search";
            this.btnSP.UseVisualStyleBackColor = true;
            // 
            // txtSsubtitle
            // 
            this.txtSsubtitle.BackColor = System.Drawing.Color.Black;
            this.txtSsubtitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSsubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSsubtitle.ForeColor = System.Drawing.Color.White;
            this.txtSsubtitle.Location = new System.Drawing.Point(10, 88);
            this.txtSsubtitle.Name = "txtSsubtitle";
            this.txtSsubtitle.Size = new System.Drawing.Size(124, 13);
            this.txtSsubtitle.TabIndex = 7;
            this.txtSsubtitle.Text = "Search products by name";
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProducts.Location = new System.Drawing.Point(10, 107);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(351, 22);
            this.txtSearchProducts.TabIndex = 5;
            // 
            // lblsubtitle
            // 
            this.lblsubtitle.AutoSize = true;
            this.lblsubtitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsubtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitle.ForeColor = System.Drawing.Color.White;
            this.lblsubtitle.Location = new System.Drawing.Point(10, 37);
            this.lblsubtitle.Name = "lblsubtitle";
            this.lblsubtitle.Size = new System.Drawing.Size(170, 18);
            this.lblsubtitle.TabIndex = 3;
            this.lblsubtitle.Text = "Process sales transactions";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnltop);
            this.panel1.Controls.Add(this.dgvProductList);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 720);
            this.panel1.TabIndex = 6;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProductList.Location = new System.Drawing.Point(24, 222);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(546, 448);
            this.dgvProductList.TabIndex = 8;
            // 
            // pnlReceipt
            // 
            this.pnlReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlReceipt.AutoScroll = true;
            this.pnlReceipt.BackColor = System.Drawing.Color.Black;
            this.pnlReceipt.Controls.Add(this.txtSubtitle2);
            this.pnlReceipt.Controls.Add(this.btnCompleteSale);
            this.pnlReceipt.Controls.Add(this.lblTotalamount);
            this.pnlReceipt.Controls.Add(this.lblTotal);
            this.pnlReceipt.Controls.Add(this.btnCredit);
            this.pnlReceipt.Controls.Add(this.btnCard);
            this.pnlReceipt.Controls.Add(this.btnCash);
            this.pnlReceipt.Controls.Add(this.dgvDisplay);
            this.pnlReceipt.Location = new System.Drawing.Point(598, 0);
            this.pnlReceipt.Name = "pnlReceipt";
            this.pnlReceipt.Size = new System.Drawing.Size(478, 720);
            this.pnlReceipt.TabIndex = 7;
            // 
            // txtSubtitle2
            // 
            this.txtSubtitle2.BackColor = System.Drawing.Color.Black;
            this.txtSubtitle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtitle2.ForeColor = System.Drawing.Color.White;
            this.txtSubtitle2.Location = new System.Drawing.Point(48, 470);
            this.txtSubtitle2.Name = "txtSubtitle2";
            this.txtSubtitle2.Size = new System.Drawing.Size(124, 13);
            this.txtSubtitle2.TabIndex = 14;
            this.txtSubtitle2.Text = "Payment Method";
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompleteSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.ForeColor = System.Drawing.Color.Black;
            this.btnCompleteSale.Location = new System.Drawing.Point(164, 627);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(164, 51);
            this.btnCompleteSale.TabIndex = 13;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            // 
            // lblTotalamount
            // 
            this.lblTotalamount.AutoSize = true;
            this.lblTotalamount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalamount.ForeColor = System.Drawing.Color.White;
            this.lblTotalamount.Location = new System.Drawing.Point(295, 567);
            this.lblTotalamount.Name = "lblTotalamount";
            this.lblTotalamount.Size = new System.Drawing.Size(43, 31);
            this.lblTotalamount.TabIndex = 12;
            this.lblTotalamount.Text = "$0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(113, 577);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 17);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL :";
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.ForeColor = System.Drawing.Color.Black;
            this.btnCredit.Location = new System.Drawing.Point(295, 498);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(95, 51);
            this.btnCredit.TabIndex = 3;
            this.btnCredit.Text = "CREDIT";
            this.btnCredit.UseVisualStyleBackColor = false;
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCard.ForeColor = System.Drawing.Color.Black;
            this.btnCard.Location = new System.Drawing.Point(174, 498);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(95, 51);
            this.btnCard.TabIndex = 2;
            this.btnCard.Text = "CARD";
            this.btnCard.UseVisualStyleBackColor = false;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.Color.Black;
            this.btnCash.Location = new System.Drawing.Point(48, 498);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(95, 51);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "CASH";
            this.btnCash.UseVisualStyleBackColor = false;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvDisplay.Location = new System.Drawing.Point(48, 70);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(342, 378);
            this.dgvDisplay.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Product Name";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Price";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quantity";
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.HeaderText = " Product Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Add ";
            this.Column5.Name = "Column5";
            this.Column5.Text = "+";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1061, 720);
            this.Controls.Add(this.pnlReceipt);
            this.Controls.Add(this.panel1);
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.pnlReceipt.ResumeLayout(false);
            this.pnlReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblsubtitle;
        private System.Windows.Forms.Label lblPOS;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.TextBox txtSsubtitle;
        private System.Windows.Forms.Panel pnlReceipt;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Label lblTotalamount;
        private System.Windows.Forms.TextBox txtSubtitle2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}