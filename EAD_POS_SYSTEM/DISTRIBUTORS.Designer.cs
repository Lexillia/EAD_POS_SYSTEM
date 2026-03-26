namespace EAD_POS_SYSTEM
{
    partial class DISTRIBUTORS
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
            this.lblsubtitle = new System.Windows.Forms.Label();
            this.lblDISTRIBUTORS = new System.Windows.Forms.Label();
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnD = new System.Windows.Forms.Button();
            this.pnltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsubtitle
            // 
            this.lblsubtitle.AutoSize = true;
            this.lblsubtitle.BackColor = System.Drawing.Color.Black;
            this.lblsubtitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitle.ForeColor = System.Drawing.Color.White;
            this.lblsubtitle.Location = new System.Drawing.Point(12, 56);
            this.lblsubtitle.Name = "lblsubtitle";
            this.lblsubtitle.Size = new System.Drawing.Size(307, 18);
            this.lblsubtitle.TabIndex = 9;
            this.lblsubtitle.Text = "Manage suppliers and automate ordering process";
            // 
            // lblDISTRIBUTORS
            // 
            this.lblDISTRIBUTORS.AutoSize = true;
            this.lblDISTRIBUTORS.BackColor = System.Drawing.Color.Black;
            this.lblDISTRIBUTORS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDISTRIBUTORS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDISTRIBUTORS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDISTRIBUTORS.ForeColor = System.Drawing.Color.White;
            this.lblDISTRIBUTORS.Location = new System.Drawing.Point(12, 23);
            this.lblDISTRIBUTORS.Name = "lblDISTRIBUTORS";
            this.lblDISTRIBUTORS.Size = new System.Drawing.Size(233, 33);
            this.lblDISTRIBUTORS.TabIndex = 8;
            this.lblDISTRIBUTORS.Text = "DISTRIBUTORS";
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.Black;
            this.pnltop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnltop.Controls.Add(this.btnD);
            this.pnltop.Controls.Add(this.lblsubtitle);
            this.pnltop.Controls.Add(this.lblDISTRIBUTORS);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(800, 100);
            this.pnltop.TabIndex = 10;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Black;
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.Location = new System.Drawing.Point(643, 49);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(129, 31);
            this.btnD.TabIndex = 15;
            this.btnD.Text = "Add Distributor";
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // DISTRIBUTORS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnltop);
            this.Name = "DISTRIBUTORS";
            this.Text = "DISTRIBUTORS";
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblsubtitle;
        private System.Windows.Forms.Label lblDISTRIBUTORS;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Button btnD;
    }
}