using Calculator.Business;

namespace Calculator.UI
{
    public partial class CalculatorForm : Form
    {        
        public CalculatorForm()
        {
            InitializeComponent();
        }

        double num1, num2, result;
        char operation;
        bool dec = false;
        AddMethod add = new AddMethod();
        DivisionMethod div = new DivisionMethod();
        MultiplyMethod mul = new MultiplyMethod();
        SubtractMethod sub = new SubtractMethod();
        FactorialMethod factorial = new FactorialMethod();
        PowMethod powM = new PowMethod();
        SqrtMethod sqrt = new SqrtMethod();        

        private void changeLabel(int numPressed)
        {
            if(dec == true)
            {
                int decimalCount = 0;
                foreach(char c in displayLabel.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    displayLabel.Text = displayLabel.Text + ".";
                }
                dec = false;
            }
            else
            {
                if(displayLabel.Text.Equals("0") == true && displayLabel.Text != null)
                {
                    displayLabel.Text = numPressed.ToString();
                }
                else if(displayLabel.Text.Equals("-0") == true)
                {
                    displayLabel.Text = "-" + numPressed.ToString();
                }
                else
                {
                    displayLabel.Text += numPressed.ToString();
                }
            }
        }
        
        private void zeroButton_Click(object sender, EventArgs e)
        {
           changeLabel(0);            
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void treeButton_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            changeLabel(9);    
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void plusminButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "-" + displayLabel.Text;
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(displayLabel.Text);
            operation = '/';
            //result = div.Division(num1, num2); //resulr = num1 / num2;
            displayLabel.Text = "";
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(displayLabel.Text);
            operation = '*';
            //result = mul.Multiply(num1, num2); //result = num1 * num2;
            displayLabel.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(displayLabel.Text);
            operation = '-';
            //result = sub.Subtract(num1, num2);  //result = num1 - num2;
            displayLabel.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(displayLabel.Text);
            operation = '+';
            result = add.Add(result, num2); //result = num1 + num2;
            displayLabel.Text = "";           

        }

        private void sqrt2Button_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                displayLabel.Text = sqrt.ToString();
            }
        }

        private void pow2Button_Click(object sender, EventArgs e)
        {
            //double y = 2;
            //double result = Math.Pow(x, y);
            //return result;
            num1 = float.Parse(displayLabel.Text);
            num2 = 2;
            if (num1 > 0)
            {
                double pow = powM.Pow2(num1);
                displayLabel.Text = pow.ToString();
            }
            else if(num1 == 0)
            {
                double pow = 0;
                displayLabel.Text = pow.ToString();
            }
        }

        private void div1Button_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            result = 1 / num1;
            displayLabel.Text = result.ToString();
        }       
       

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            int stringLength = displayLabel.Text.Length;
            if (stringLength > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, stringLength - 1);
            }
            else
            {
                displayLabel.Text = "0";
            }
        }

        private void factButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            if (num1 > 0)
            {
                double fact = factorial.Factorial(num1);
                displayLabel.Text = fact.ToString();
            }
        }

        private void xpowYButton_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(displayLabel.Text);
            operation = '^';
            
            displayLabel.Text = "";
        }

        private void xpow3Button_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            num2 = 3;
            if (num1 > 0)
            {
                double pow = powM.Pow3(num1);
                displayLabel.Text = pow.ToString();
            }
            else if (num1 == 0)
            {
                double pow = 0;
                displayLabel.Text = pow.ToString();
            }
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            result = 0;
            if (displayLabel.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = double.Parse(displayLabel.Text);
                        result = add.Add(num1, num2);                        
                        break;
                    case '-':
                        num2 = double.Parse(displayLabel.Text);
                        result = sub.Subtract(num1, num2);
                        break;
                    case '/':
                        num2 = double.Parse(displayLabel.Text);
                        result = div.Division(num1, num2);
                        break;
                    case '*':
                        num2 = double.Parse(displayLabel.Text);
                        result = mul.Multiply(num1, num2);
                        break;
                    case '^':
                        num2 = double.Parse(displayLabel.Text);
                        result = powM.Pow(num1, num2);
                        break;
                    default:
                        break;
                }
            }
            displayLabel.Text = result.ToString();
        }      

    }
}
