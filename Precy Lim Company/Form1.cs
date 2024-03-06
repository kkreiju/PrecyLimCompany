using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precy_Lim_Company
{
    public partial class Form1 : Form
    {
        const int small = 200;
        const int medium = 200;
        const int large = 200;
        const int extralarge = 220;
        const int xxl = 240;
        int quantity;
        string size;
        ArrayList sizearraylist = new ArrayList();
        ArrayList designarraylist = new ArrayList();
        ArrayList pricearraylist = new ArrayList();
        ArrayList quantityarraylist = new ArrayList();
        bool ordercomplete = false;
        public Form1()
        {
            InitializeComponent();
        }

        //programmer defined methods
        public int TshirtPricing(int price)
        {
            if (MonogramCheckbox.Checked)
                return price + 40;
            else if (PocketCheckbox.Checked)
                return price + 20;
            else
                return price;
        }


        public void CheckSize()
        {
            if(QuantityTextbox.Text != string.Empty)
            {
                if (SmallRadioButton.Checked)
                {
                    CurrentOrderLabel.Text = (TshirtPricing(small) * Convert.ToInt32(QuantityTextbox.Text)).ToString();
                    size = "Small";
                }
                else if (MediumRadioButton.Checked)
                {
                    CurrentOrderLabel.Text = (TshirtPricing(medium) * Convert.ToInt32(QuantityTextbox.Text)).ToString();
                    size = "Medium";
                }
                else if (LargeRadioButton.Checked)
                {
                    CurrentOrderLabel.Text = (TshirtPricing(large) * Convert.ToInt32(QuantityTextbox.Text)).ToString();
                    size = "Large";
                }
                else if (ExtraLargeRadioButton.Checked)
                {
                    CurrentOrderLabel.Text = (TshirtPricing(extralarge) * Convert.ToInt32(QuantityTextbox.Text)).ToString();
                    size = "XL";
                }
                else if (XXLRadioButton.Checked)
                {
                    CurrentOrderLabel.Text = (TshirtPricing(xxl) * Convert.ToInt32(QuantityTextbox.Text)).ToString();
                    size = "XXL";
                }
            }
        }

        public int UpdateOrderTotal()
        {
            int ordertotal = 0;
            for(int i = 0; i < pricearraylist.Count; i++)
            {
                ordertotal += (int) pricearraylist[i];
            }
            return ordertotal;
        }

        private void SmallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckSize();
        }

        
        private void MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckSize();
        }

        private void LargeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckSize();
        }

        private void ExtraLargeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckSize();
        }

        private void XXLRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckSize();
        }

        private void MonogramCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckSize();
        }

        private void PocketCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckSize();
        }

        private void AddTshirtButton_Click(object sender, EventArgs e)
        {
            if (QuantityTextbox.Text == string.Empty)
            {
                MessageBox.Show("Empty Quantity!");
            }
            else if(Convert.ToInt16(QuantityTextbox.Text) > 0)
            {
                quantity = Convert.ToInt32(QuantityTextbox.Text);
                sizearraylist.Add(size);
                if (MonogramCheckbox.Checked && PocketCheckbox.Checked)
                    designarraylist.Add("Monogram, Pocket");
                else if (MonogramCheckbox.Checked)
                    designarraylist.Add("Monogram");
                else if (PocketCheckbox.Checked)
                    designarraylist.Add("Pocket");
                else
                    designarraylist.Add("None");
                pricearraylist.Add(Convert.ToInt32(CurrentOrderLabel.Text) * quantity);
                OrderTotalLabel.Text = (UpdateOrderTotal()).ToString();
            }
            else
            {
                MessageBox.Show("Quantity is Invalid!");
            }
            
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            if (!ordercomplete)
                MessageBox.Show("Order Incomplete, Please Confirm your Orders.");
            else
            {

                string output = "Name: " + NameTextbox.Text + "\nOrder Number: " + OrderNumberTextbox.Text + "\nSize \t\t Design \t\t\t Price\n";
                for(int i = 0; i < pricearraylist.Count; i++)
                {
                    output += sizearraylist[i] + " \t\t " + designarraylist[i] + " \t\t " + pricearraylist[i] + "\n";
                }
                output += "\n\nOrder Total = " + OrderTotalLabel.Text;
                MessageBox.Show(output);
            }
           
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            ordercomplete = true;
            NameTextbox.Enabled = false;
            OrderNumberTextbox.Enabled = false;
            MessageBox.Show("Order Completed!");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SmallRadioButton.Checked = false;
            MediumRadioButton.Checked = false; 
            LargeRadioButton.Checked = false;
            ExtraLargeRadioButton.Checked = false;
            XXLRadioButton.Checked = false;
            MonogramCheckbox.Checked = false;
            PocketCheckbox.Checked = false;
            CurrentOrderLabel.Text = string.Empty;
        }

        private void QuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            CheckSize();
        }
    }
}
