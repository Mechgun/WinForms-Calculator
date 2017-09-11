///////////////////////////31927 Application Development with C# .NET//////////////////////////////
///////////////////////////////////////Assignment 2////////////////////////////////////////////////
//////////////////////////////////Jizhen Zhang 99209126////////////////////////////////////////////

using System;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool zeroButtonWasClicked = false;
        private bool resultIsGiven = false;
        private bool errorOutput = false;

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "1";
            }
            else
            {
                outputBox.Text = outputBox.Text + "1";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "2";
            }
            else
            {
                outputBox.Text = outputBox.Text + "2";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "3";
            }
            else
            {
                outputBox.Text = outputBox.Text + "3";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "4";
            }
            else
            {
                outputBox.Text = outputBox.Text + "4";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "5";
            }
            else
            {
                outputBox.Text = outputBox.Text + "5";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "6";
            }
            else
            {
                outputBox.Text = outputBox.Text + "6";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "7";
            }
            else
            {
                outputBox.Text = outputBox.Text + "7";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "8";
            }
            else
            {
                outputBox.Text = outputBox.Text + "8";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "9";
            }
            else
            {
                outputBox.Text = outputBox.Text + "9";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "0" || resultIsGiven || errorOutput)
            {
                outputBox.Text = "0";
            }
            else
            {
                outputBox.Text = outputBox.Text + "0";
            }
            errorOutput = false;
            resultIsGiven = false;
            zeroButtonWasClicked = true;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (errorOutput)
            {
                outputBox.Text = ".";
            }
            else
            {
                outputBox.Text = outputBox.Text + ".";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((outputBox.Text == "0" && !zeroButtonWasClicked) || errorOutput)
            {
                outputBox.Text = "+";
            }
            else
            {
                outputBox.Text = outputBox.Text + "+";
            }
            errorOutput = false;
            resultIsGiven = false;
            zeroButtonWasClicked = false;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if ((outputBox.Text == "0" && !zeroButtonWasClicked) || errorOutput)
            {
                outputBox.Text = "-";
            }
            else
            {
                outputBox.Text = outputBox.Text + "-";
            }
            errorOutput = false;
            resultIsGiven = false;
            zeroButtonWasClicked = false;
        }

        private void mutipleButton_Click(object sender, EventArgs e)
        {
            if (errorOutput)
            {
                outputBox.Text = "×";
            }
            else
            {
                outputBox.Text = outputBox.Text + "×";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (errorOutput)
            {
                outputBox.Text = "/";
            }
            else
            {
                outputBox.Text = outputBox.Text + "/";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void moduleButton_Click(object sender, EventArgs e)
        {
            if (errorOutput)
            {
                outputBox.Text = "%";
            }
            else
            {
                outputBox.Text = outputBox.Text + "%";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            if (errorOutput)
            {
                outputBox.Text = "^";
            }
            else
            {
                outputBox.Text = outputBox.Text + "^";
            }
            errorOutput = false;
            resultIsGiven = false;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (outputBox.Text.Length > 0)
            {
                outputBox.Text = outputBox.Text.Remove(outputBox.Text.Length - 1, 1);
            }
            if (outputBox.Text.Length == 0 || errorOutput)
            {
                outputBox.Text = "0";
            }
            zeroButtonWasClicked = false;
            errorOutput = false;
            resultIsGiven = false;
        }

        private void buttonCL_Click(object sender, EventArgs e)
        {
            outputBox.Text = "0";
            zeroButtonWasClicked = false;
            errorOutput = false;
            resultIsGiven = false;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            string expression = outputBox.Text;
            string[] newExpression = Validator.splitExpression(expression);       ///First split the input string into
            if (!Validator.checkExpValidation(ref newExpression))                 ///a array. Each elements contains either
            {                                                                     ///numbers or operators. Check each elements
                outputBox.Text = "Invalid Double";                                ///that all has valide variables
                errorOutput = true;
            }                                                          
            else
            {                                                           ///In order to calculate with unary operators. Add
                Validator.addOperator(newExpression);                   ///"+" in every single operators to make all operators
                if (!Validator.checkZero(newExpression))                ///has to sign
                {
                    outputBox.Text = "∞";              ///If zero appears after % or /, display ∞
                    errorOutput = true;
                }
                else
                {
                    string result = Calculator.evaluation(newExpression);  ///Send expression to calculator to evaluate.
                    outputBox.Text = result;
                    resultIsGiven = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void outputBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
