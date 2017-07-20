using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // converts textboxes to integers so they can do the calculations and then to strings so they can be displayed
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

            double amount = (Convert.ToInt32(textBox1.Text));       //get amount
            double totalAmount = amount * 0.15;
            textBox2.Text = totalAmount.ToString("C2");             // 15 % tip    

            textBox4.Text = (amount + totalAmount).ToString("C2");  //write out amount with tip added

            totalAmount = amount * 0.20;    //calulate 20% tip
            textBox3.Text = totalAmount.ToString("C2");             // 15 % tip    

            textBox5.Text = (amount + totalAmount).ToString("C2");  //write out amount with tip added




        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only for numbers to be input into textbox1 otherwise messagebox appears explaining whats wrong
            char onlyNumbers = e.KeyChar;

            if (!Char.IsDigit(onlyNumbers) && onlyNumbers != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only Enter Numbers");
            }
          

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
