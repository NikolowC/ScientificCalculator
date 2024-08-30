using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operatorClicked = "";
        bool isOperatorClicked = false;
        bool isDecimalUsed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "0" && !isOperatorClicked)
                textBoxDisplay.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }


        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void buttonCloseParenthesis_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += ")";
        }

        private void buttonOpenParenthesis_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "(";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "+";
            operatorClicked = "+";


        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "-";
            operatorClicked = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "*";
            operatorClicked = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "÷";
            operatorClicked = "÷";
        }

        private void buttonTan_Click(object sender, EventArgs e)
         {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Tan(tmp);
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Sin(tmp);
            }
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Cos(tmp);
            }
        }

        private void buttonCtg_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                double radians = double.Parse(textBoxDisplay.Text) * (Math.PI / 180);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += 1 / Math.Tan(radians);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Log10(tmp);
            }
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Log(tmp);
            }

        }


        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBoxDisplay.Text;
                expression = expression.Replace("÷", "/");
                var result = new DataTable().Compute(expression, null);
                textBoxDisplay.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Pow(tmp,2);
            }
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.PI * tmp;
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Sqrt(tmp);
            }
        }

        private void buttonAbs_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Abs(tmp);
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "%";
            operatorClicked = "%";
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += tmp * 2.718281828459045;
            }
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                var tmp = double.Parse(textBoxDisplay.Text);
                textBoxDisplay.Text = "";
                textBoxDisplay.Text += Math.Exp(tmp);
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += ",";
        }

        private double Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBoxDisplay.Text);
                if (number < 0)
                {
                    MessageBox.Show("Factorial is not defined for negative numbers.");
                    return;
                }

                resultValue = Factorial(number);
                textBoxDisplay.Text = resultValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1);
            }
        }
    }
}

