using System;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            Total1 = 0.0;
            Total2 = 0.0;
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {   float Totalx;
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        double Total1 = 0;
        double Total2 = 0;
        private bool plusbtnClicked = false;
        private bool minusbtnClicked = false;
        private bool dividebtnClicked = false;
        private bool mulbtnClicked = false;

        private void btnPlus_Click(object sender, EventArgs e)
        {           
             Total1 += double.Parse(txtDisplay.Text);
             txtDisplay.Clear();
             
           /* plusbtnClicked = true;
            minusbtnClicked = false;
            dividebtnClicked = false;
            mulbtnClicked = false;
            */
            _theOperator = "+";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            /* plusbtnClicked = false;
            minusbtnClicked = true;
            dividebtnClicked = false;
            mulbtnClicked = false;
             */
            _theOperator = "-";

        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            Total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            /* plusbtnClicked = false;
            minusbtnClicked = false;
            dividebtnClicked = true;
            mulbtnClicked = false;
             */
            _theOperator = "/";
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            Total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            /* plusbtnClicked = false;
            minusbtnClicked = false;
            dividebtnClicked = false;
            mulbtnClicked = true;
             */
            _theOperator = "*";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private string _theOperator;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            /*
            if (plusbtnClicked == true)
            {
                Total2 = Total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusbtnClicked == true)
            {
                Total2 = Total1 - double.Parse(txtDisplay.Text);

            }
            else if (dividebtnClicked == true)
            {
                Total2 = Total1 / double.Parse(txtDisplay.Text);
            }
            else if (mulbtnClicked == true)
            {
                Total2 = Total1 * double.Parse(txtDisplay.Text);
            }
             */

            switch(_theOperator)
            {
                case "+":
                    Total2 = Total1 + double.Parse(txtDisplay.Text);
                    break;
                    
                case "-":
                    Total2 = Total1 - double.Parse(txtDisplay.Text);
                    break;

                case "/":
                    Total2 = Total1/double.Parse(txtDisplay.Text);
                    break;

                case  "*":
                    Total2 = Total1*double.Parse(txtDisplay.Text);
                    break;

                default:
                    break;
            }

            txtDisplay.Text = Total2.ToString();
            Total1 = 0;
        }       
             
    }
}
