using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_444
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "2";

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "3";

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "4";

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "5";

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "6";

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "7";

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "8";

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "9";

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }

            txtNumber.Text = txtNumber.Text + "0";

        }
        float firstNumber, secondNumber; 
        int operators = -1; 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); 
            txtNumber.Text = "0"; 
            operators = 0; 
        }
        
        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 1; 
        }
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 2;
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = 3;
        }
    }
}
