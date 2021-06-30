using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_continue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((txtBx1.Text == "0") || (operation_continue))
                txtBx1.Clear();

            operation_continue = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!txtBx1.Text.Contains("."))
                    txtBx1.Text = txtBx1.Text + b.Text;
            }
            else
            txtBx1.Text = txtBx1.Text + b.Text;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtBx1.Text = "0";
        }

        private void operation_button(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                btnEqual.PerformClick();

            }
            else
            {
                operation = b.Text;
                value = double.Parse(txtBx1.Text);
                operation_continue = true;
                lbl1.Text = value + "" + operation;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
            switch (operation)
            {
                case "+":
                    txtBx1.Text = (value + double.Parse(txtBx1.Text)).ToString();
                    break;
                case "-":
                    txtBx1.Text = (value - double.Parse(txtBx1.Text)).ToString();
                    break;
                case "x":
                    txtBx1.Text = (value * double.Parse(txtBx1.Text)).ToString();
                    break;
                case "/":
                    txtBx1.Text = (value / double.Parse(txtBx1.Text)).ToString();
                    break;
            }
            


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBx1.Clear();
            value = 0;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
