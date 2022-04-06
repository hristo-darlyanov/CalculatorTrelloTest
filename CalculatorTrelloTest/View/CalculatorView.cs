using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTrelloTest.View
{
    public partial class CalculatorView : Form
    {
        public CalculatorView()
        {
            InitializeComponent();
        }
        double num1, ans;
        int count;
        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                double squareRoot = double.Parse(txtBox.Text);
                squareRoot = Math.Sqrt(squareRoot);
                txtBox.Text = squareRoot.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                num1 = double.Parse(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();
                count = 2;
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                txtBox.Clear();
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                num1 = double.Parse(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();
                count = 1;
            }
        }

        private void btnMultipy_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                num1 = double.Parse(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();
                count = 3;
            }
        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                num1 = double.Parse(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();
                count = 4;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                num1 = double.Parse(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();
                count = 5;
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                num1 = double.Parse(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();
                count = 6;
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                double reverseSign = double.Parse(txtBox.Text);
                reverseSign = reverseSign - reverseSign * 2;
                txtBox.Text = reverseSign.ToString();
            }
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                case 5:
                    ans = num1 % float.Parse(txtBox.Text);
                    txtBox.Text = ans.ToString();
                    break;
                case 6:
                    ans = Math.Pow(num1,float.Parse(txtBox.Text));
                    txtBox.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
