namespace EAD_POS_SYSTEM
{
    partial class MdiParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMILogout = new System.Windows.Forms.ToolStripMenuItem();
            this.SMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.POS = new System.Windows.Forms.ToolStripMenuItem();
            this.CUSTOMERS = new System.Windows.Forms.ToolStripMenuItem();
            this.INVENTORY = new System.Windows.Forms.ToolStripMenuItem();
            this.DISTRIBUTERS = new System.Windows.Forms.ToolStripMenuItem();
            this.AUTOORDER = new System.Windows.Forms.ToolStripMenuItem();
            this.REPORTS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMILogout,
            this.SMIExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SMILogout
            // 
            this.SMILogout.Name = "SMILogout";
            this.SMILogout.Size = new System.Drawing.Size(112, 22);
            this.SMILogout.Text = "Logout";
            this.SMILogout.Click += new System.EventHandler(this.SMILogout_Click);
            // 
            // SMIExit
            // 
            this.SMIExit.Name = "SMIExit";
            this.SMIExit.Size = new System.Drawing.Size(112, 22);
            this.SMIExit.Text = "Exit";
            this.SMIExit.Click += new System.EventHandler(this.SMIExit_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dASHBOARDToolStripMenuItem,
            this.POS,
            this.CUSTOMERS,
            this.INVENTORY,
            this.DISTRIBUTERS,
            this.AUTOORDER,
            this.REPORTS});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            this.dASHBOARDToolStripMenuItem.Click += new System.EventHandler(this.dASHBOARDToolStripMenuItem_Click);
            // 
            // POS
            // 
            this.POS.Name = "POS";
            this.POS.Size = new System.Drawing.Size(180, 22);
            this.POS.Text = "POS";
            this.POS.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // CUSTOMERS
            // 
            this.CUSTOMERS.Name = "CUSTOMERS";
            this.CUSTOMERS.Size = new System.Drawing.Size(180, 22);
            this.CUSTOMERS.Text = "CUSTOMERS";
            this.CUSTOMERS.Click += new System.EventHandler(this.CUSTOMERS_Click);
            // 
            // INVENTORY
            // 
            this.INVENTORY.Name = "INVENTORY";
            this.INVENTORY.Size = new System.Drawing.Size(180, 22);
            this.INVENTORY.Text = "INVENTORY";
            this.INVENTORY.Click += new System.EventHandler(this.INVENTORY_Click);
            // 
            // DISTRIBUTERS
            // 
            this.DISTRIBUTERS.Name = "DISTRIBUTERS";
            this.DISTRIBUTERS.Size = new System.Drawing.Size(180, 22);
            this.DISTRIBUTERS.Text = "DISTRIBUTORS";
            this.DISTRIBUTERS.Click += new System.EventHandler(this.DISTRIBUTERS_Click);
            // 
            // AUTOORDER
            // 
            this.AUTOORDER.Name = "AUTOORDER";
            this.AUTOORDER.Size = new System.Drawing.Size(180, 22);
            this.AUTOORDER.Text = "AUTO-ORDER";
            this.AUTOORDER.Click += new System.EventHandler(this.AUTOORDER_Click);
            // 
            // REPORTS
            // 
            this.REPORTS.Name = "REPORTS";
            this.REPORTS.Size = new System.Drawing.Size(180, 22);
            this.REPORTS.Text = "REPORTS";
            this.REPORTS.Click += new System.EventHandler(this.REPORTS_Click);
            // 
            // MdiParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 445);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiParent";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SMILogout;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem POS;
        private System.Windows.Forms.ToolStripMenuItem CUSTOMERS;
        private System.Windows.Forms.ToolStripMenuItem INVENTORY;
        private System.Windows.Forms.ToolStripMenuItem DISTRIBUTERS;
        private System.Windows.Forms.ToolStripMenuItem AUTOORDER;
        private System.Windows.Forms.ToolStripMenuItem REPORTS;
        private System.Windows.Forms.ToolStripMenuItem SMIExit;
    }
}

