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

            Button b = (Button)sender;
            txtBx1.Text = txtBx1.Text + b.Text;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtBx1.Text = "0";
        }

        private void operation_button(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(txtBx1.Text);
            operation_continue = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

        }
    }
}
