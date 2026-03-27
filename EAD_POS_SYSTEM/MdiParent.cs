using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // You need this using directive for OfType<T>() and SingleOrDefault()
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAD_POS_SYSTEM
{
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();
            // Link the Load event of the form to a new method
            this.Load += MdiParent_Load;
        }

        public void MdiParent_Load(object sender, EventArgs e)
        {
            // This automatically "clicks" the Dashboard menu item for you
            dASHBOARDToolStripMenuItem_Click(sender, e);
        }

        public void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Close any other open child forms first
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // 2. Create and setup the new form
            DASHBOARD newChild = new DASHBOARD ();
            newChild.MdiParent = this;

            // These lines ensure it stays "borderless" and fills the screen
            newChild.FormBorderStyle = FormBorderStyle.None;
            newChild.Dock = DockStyle.Fill;

            newChild.Show();
        }

       public void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Close any other open child forms first
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // 2. Create and setup the new form
            POS newChild = new POS();
            newChild.MdiParent = this;

            // These lines ensure it stays "borderless" and fills the screen
            newChild.FormBorderStyle = FormBorderStyle.None;
            newChild.Dock = DockStyle.Fill;

            newChild.Show();
        }

        public void CUSTOMERS_Click(object sender, EventArgs e)
        {
            // 1. Close any other open child forms first
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // 2. Create and setup the new form
            CUSTOMERS newChild = new CUSTOMERS();
            newChild.MdiParent = this;

            // These lines ensure it stays "borderless" and fills the screen
            newChild.FormBorderStyle = FormBorderStyle.None;
            newChild.Dock = DockStyle.Fill;

            newChild.Show();
        }

        public void INVENTORY_Click(object sender, EventArgs e)
        {
            // 1. Close any other open child forms first
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // 2. Create and setup the new form
            INVENTORY newChild = new INVENTORY();
            newChild.MdiParent = this;

            // These lines ensure it stays "borderless" and fills the screen
            newChild.FormBorderStyle = FormBorderStyle.None;
            newChild.Dock = DockStyle.Fill;

            newChild.Show();
        }

        public void DISTRIBUTERS_Click(object sender, EventArgs e)
        {
            // 1. Close any other open child forms first
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // 2. Create and setup the new form
            DISTRIBUTORS newChild = new DISTRIBUTORS ();
            newChild.MdiParent = this;

            // These lines ensure it stays "borderless" and fills the screen
            newChild.FormBorderStyle = FormBorderStyle.None;
            newChild.Dock = DockStyle.Fill;

            newChild.Show();
        }

        public void AUTOORDER_Click(object sender, EventArgs e)
        {
            // 1. Close any other open child forms first
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // 2. Create and setup the new form
            AUTOORDER newChild = new AUTOORDER();
            newChild.MdiParent = this;

            // These lines ensure it stays "borderless" and fills the screen
            newChild.FormBorderStyle = FormBorderStyle.None;
            newChild.Dock = DockStyle.Fill;

            newChild.Show();
        }

        public void REPORTS_Click(object sender, EventArgs e)
        {
            // 1. Close any other open child forms first
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // 2. Create and setup the new form
            REPORTS newChild = new REPORTS();
            newChild.MdiParent = this;

            // These lines ensure it stays "borderless" and fills the screen
            newChild.FormBorderStyle = FormBorderStyle.None;
            newChild.Dock = DockStyle.Fill;

            newChild.Show();
        }

        private void SMIExit_Click(object sender, EventArgs e)
        {
            {
                {
                    // Rubric Check: MessageBox for user feedback
                    DialogResult confirm = MessageBox.Show("Are you sure you want to exit the system?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void SMIExit_Click_1(object sender, EventArgs e)
        {
            {
                // Check if there is an active child form open
                if (this.ActiveMdiChild != null)
                {
                    // Close only the active window (e.g., Dashboard or POS)
                    this.ActiveMdiChild.Close();
                }
                else
                {
                    // Optional: If no forms are open, ask to close the whole app
                    DialogResult result = MessageBox.Show("No forms are open. Close the whole application?", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void SMILogout_Click(object sender, EventArgs e)
        {
            {
                // Rubric Check: Provide feedback/confirmation
                DialogResult confirm = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confirm == DialogResult.Yes)
                {
                    // This closes the current MDI Parent and triggers the restart logic in Program.cs
                    this.Hide();
                    LOGIN loginForm = new LOGIN();
                    loginForm.Show();
                }
            }
        }

        private void MdiParent_Load_1(object sender, EventArgs e)
        {

        }
    }
    }
    
    
    
 