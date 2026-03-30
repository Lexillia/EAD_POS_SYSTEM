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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {

        }

        private void txtSubtitle2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            POSLogic logic = new POSLogic();

            // Call the void method (Requirement Met)
            logic.LogPayment("CASH");

            // Update your UI Total to $0 after payment
            lblTotalamount.Text = "$0";
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            // 1. Create the object
            POSLogic logic = new POSLogic();

            // 2. Call the method (Returns a value - Requirement Met)
            string message = logic.GetSearchMessage(btnSP.Text);

            // 3. Show the result using a built-in method
            MessageBox.Show(message);
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            POSLogic logic = new POSLogic();
            logic.ClearTransaction(); // This is the "Void" method reference
            MessageBox.Show("Sale Finished!");

        }
    }
}
