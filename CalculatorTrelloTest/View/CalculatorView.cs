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
                if (double.TryParse(txtBox.Text, out var x))
                {
                    num1 = double.Parse(txtBox.Text);
                    txtBox.Text = Math.Sqrt(num1).ToString();                 
                    txtBox.Focus();
                }
                else
                {
                    MessageBox.Show("Please use number");
                    txtBox.Clear();
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            {
                if (txtBox.Text.Length > 0)
                {
                    if (double.TryParse(txtBox.Text, out var x))
                    {
                        num1 = double.Parse(txtBox.Text);
                        txtBox.Clear();
                        txtBox.Focus();
                        count = 2;
                    }
                    else
                    {
                        MessageBox.Show("Please use number");
                        txtBox.Clear();
                    }
                }
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
            Compute(count);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                if (double.TryParse(txtBox.Text, out var x))
                {
                    num1 = double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Focus();
                    count = 1;
                }
                else
                {
                    MessageBox.Show("Please use number");
                    txtBox.Clear();
                }
            }
        }

        private void btnMultipy_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                if (double.TryParse(txtBox.Text, out var x))
                {
                    num1 = double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Focus();
                    count = 3;
                }
                else
                {
                    MessageBox.Show("Please use number");
                    txtBox.Clear();
                }
            }
        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                if (double.TryParse(txtBox.Text, out var x))
                {
                    num1 = double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Focus();
                    count = 4;
                }
                else
                {
                    MessageBox.Show("Please use number");
                    txtBox.Clear();
                }
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                if (double.TryParse(txtBox.Text, out var x))
                {
                    num1 = double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Focus();
                    count = 5;
                }
                else
                {
                    MessageBox.Show("Please use number");
                    txtBox.Clear();
                }
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                if (double.TryParse(txtBox.Text, out var x))
                {
                    num1 = double.Parse(txtBox.Text);
                    txtBox.Clear();
                    txtBox.Focus();
                    count = 6;
                }
                else
                {
                    MessageBox.Show("Please use number!");
                    txtBox.Clear();
                }
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                if (double.TryParse(txtBox.Text, out var x))
                {
                    double reverseSign = double.Parse(txtBox.Text);
                    reverseSign = reverseSign - reverseSign * 2;
                    txtBox.Text = reverseSign.ToString();
                }
                else
                {
                    MessageBox.Show("Please use number");
                    txtBox.Clear();
                }
            }
        }

        public void Compute(int count)
        {
            switch (count)
            {
                case 1:
                    if (txtBox.Text.Length > 0)
                    {
                        if (double.TryParse(txtBox.Text, out var x))
                        {
                            ans = num1 - float.Parse(txtBox.Text);
                            txtBox.Text = ans.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Please use number!");
                            txtBox.Clear();
                        }
                    }
                    break;
                case 2:
                    if (txtBox.Text.Length > 0)
                    {
                        if (double.TryParse(txtBox.Text, out var x))
                        {
                            ans = num1 + float.Parse(txtBox.Text);
                            txtBox.Text = ans.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Please use number!");
                            txtBox.Clear();
                        }
                    }
                    break;
                case 3:
                    if (txtBox.Text.Length > 0)
                    {
                        if (double.TryParse(txtBox.Text, out var x))
                        {
                            ans = num1 * float.Parse(txtBox.Text);
                            txtBox.Text = ans.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Please use number!");
                            txtBox.Clear();
                        }
                    }
                    break;
                case 4:
                    if (txtBox.Text.Length > 0)
                    {
                        if (double.TryParse(txtBox.Text, out var x))
                        {
                            ans = num1 / float.Parse(txtBox.Text);
                            txtBox.Text = ans.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Please use number!");
                            txtBox.Clear();
                        }
                    }
                    break;
                case 5:
                    if (txtBox.Text.Length > 0)
                    {
                        if (double.TryParse(txtBox.Text, out var x))
                        {
                            ans = num1 % float.Parse(txtBox.Text);
                            txtBox.Text = ans.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Please use number!");
                            txtBox.Clear();
                        }
                    }
                    break;
                case 6:
                    if (txtBox.Text.Length > 0)
                    {
                        if (double.TryParse(txtBox.Text, out var x))
                        {
                            ans = Math.Pow(num1,float.Parse(txtBox.Text));
                            txtBox.Text = ans.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Please use number!");
                            txtBox.Clear();
                        }
                    }
                    break;
                default:
                    break;                   
            }
        }
    }
}
