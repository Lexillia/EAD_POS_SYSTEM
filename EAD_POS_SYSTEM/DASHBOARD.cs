using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAD_POS_SYSTEM
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void btnNS_Click(object sender, EventArgs e)
        {
            // Access the MDI Parent to switch forms
            if (this.MdiParent != null)
            {
                // 1. Close current child forms (including this Dashboard)
                foreach (Form child in this.MdiParent.MdiChildren)
                {
                    child.Close();
                }

                // 2. Create and setup the POS form
                POS newChild = new POS();
                newChild.MdiParent = this.MdiParent;

                // Match the formatting from your MdiParent code
                newChild.FormBorderStyle = FormBorderStyle.None;
                newChild.Dock = DockStyle.Fill;

                newChild.Show();

            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        
            {
                if (this.MdiParent != null)
                {
                    foreach (Form child in this.MdiParent.MdiChildren)
                    {
                        child.Close();
                    }

                    CUSTOMERS newChild = new CUSTOMERS();
                    newChild.MdiParent = this.MdiParent;
                    newChild.FormBorderStyle = FormBorderStyle.None;
                    newChild.Dock = DockStyle.Fill;
                    newChild.Show();

                }
            }

        private void btnUI_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                foreach (Form child in this.MdiParent.MdiChildren)
                {
                    child.Close();
                }

                INVENTORY newChild = new INVENTORY();
                newChild.MdiParent = this.MdiParent;
                newChild.FormBorderStyle = FormBorderStyle.None;
                newChild.Dock = DockStyle.Fill;
                newChild.Show();
            }
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                foreach (Form child in this.MdiParent.MdiChildren)
                {
                    child.Close();
                }

                REPORTS newChild = new REPORTS();
                newChild.MdiParent = this.MdiParent;
                newChild.FormBorderStyle = FormBorderStyle.None;
                newChild.Dock = DockStyle.Fill;
                newChild.Show();
            }
        }
    }
}
