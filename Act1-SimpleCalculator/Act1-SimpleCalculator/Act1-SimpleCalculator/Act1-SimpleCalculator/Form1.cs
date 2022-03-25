using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act1_SimpleCalculator
{
    public partial class frmCal : Form
    {
        Double result = 0;
        String operation = "";
        bool operationPer = false;

        public frmCal()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn1.Text;
            operationPer = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn0.Text;
            operationPer = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn2.Text;
            operationPer = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn3.Text;
            operationPer = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn4.Text;
            operationPer = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn5.Text;
            operationPer = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn6.Text;
            operationPer = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn7.Text;
            operationPer = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn8.Text;
            operationPer = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btn9.Text;
            operationPer = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "0")
            {
                txtValue.Text = "0";
            }
            result = 0;
         
            lblCurrentOperation.Text = "";
            btnDecimal.Enabled = true;

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
            {
                txtValue.Clear();
            }
            txtValue.Text += btnDecimal.Text;
            operationPer = false;
            btnDecimal.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = btnAdd.Text;
            result = Double.Parse(txtValue.Text);

            operationPer = true;

            lblCurrentOperation.Text = result + " " + btnAdd.Text;
            txtValue.Text = "0";
            btnDecimal.Enabled = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = btnMinus.Text;
            result = Double.Parse(txtValue.Text);
            operationPer = true;

            lblCurrentOperation.Text = result + " " + btnMinus.Text;
            txtValue.Text = "0";
            btnDecimal.Enabled = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = btnMulti.Text;
            result = Double.Parse(txtValue.Text);
            operationPer = true;

            lblCurrentOperation.Text = result + " " + btnMulti.Text;
            txtValue.Text = "0";
            btnDecimal.Enabled = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = btnDivide.Text;
            result = Double.Parse(txtValue.Text);
            operationPer = true;

            lblCurrentOperation.Text = result + " " + btnDivide.Text;
            txtValue.Text = "0";
            btnDecimal.Enabled = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double result2 = Double.Parse(txtValue.Text);
            switch (operation)
            {
                case "+":
                    txtValue.Text = (result + Double.Parse(txtValue.Text)).ToString();
                break;

                case "-":
                    txtValue.Text = (result - Double.Parse(txtValue.Text)).ToString();
                break;

                case "*":
                    txtValue.Text = (result * Double.Parse(txtValue.Text)).ToString();
                break;

                case "/":
                    txtValue.Text = (result / Double.Parse(txtValue.Text)).ToString();
                break;
                
                default:
                break;
            }
            lblCurrentOperation.Text += " " + result2;
        }
    }
}
