using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise_18_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double tax = Convert.ToDouble(txtAmount.Text) * (Convert.ToDouble(nudTax.Value) * 0.01);
                double total = Convert.ToDouble(txtAmount.Text) + tax;
                string resultString = "Tax on $"
                                      + txtAmount.Text
                                      + " at "
                                      + nudTax.Value
                                      + "% is $"
                                      + tax.ToString("F")
                                      + ".\nThe total is $"
                                      + total.ToString("F")
                                      + ".";

                lblResult.Text = resultString;
            }
            catch (FormatException)
            {
                DialogResult error = MessageBox.Show(
                    "Please enter a number",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAmount.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
        }

    }
}
