using ItemNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplicationn
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        double totalAmount = 0;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
           
            string itemName = txtItem.Text;

            double price = Convert.ToDouble(txtPrice.Text);

            double discount =
                Convert.ToDouble(txtDiscount.Text);

            int quantity =
                Convert.ToInt32(txtQuantity.Text);

            DiscountedItem item =
                new DiscountedItem(itemName, price, discount);

            totalAmount = item.getTotalPrice(quantity);

            lblTotal.Text = totalAmount.ToString("0.00");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double payment =
                Convert.ToDouble(txtPayment.Text);

            double change = payment - totalAmount;

            lblChange.Text = change.ToString("0.00");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmLoginAccount login =
        new frmLoginAccount();

            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
