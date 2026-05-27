using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplicationn
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Cashier cashier = new Cashier(
                "cashier",
                "12345",
                "Mario Bitago",
                "Sales Department"
            );

            bool result = cashier.validateLogin(
                txtUsername.Text,
                txtPassword.Text
            );

            if (result == true)
            {
                MessageBox.Show(
                    "Welcome " +
                    cashier.getFullName() +
                    "\nDepartment: " +
                    cashier.getDepartment()
                );

                frmPurchaseDiscountedItem form =
                    new frmPurchaseDiscountedItem();

                form.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username or Password"
                );
            }
        }
    
    }
}
