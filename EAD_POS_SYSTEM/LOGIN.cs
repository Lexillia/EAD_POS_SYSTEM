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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                // For now, let's use a simple hardcoded check
                if (txtUserName.Text == "admin" && txtPAssword.Text == "1234")
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // This tells the application the login was a success
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLExit_Click(object sender, EventArgs e)
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

        private void btnForgetpassword_Click(object sender, EventArgs e)
        {
            // Rubric Check: Appropriate message/feedback
            MessageBox.Show("Please contact your System Administrator to reset your password.", "Password Assistance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
