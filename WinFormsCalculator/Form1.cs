using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class MainForm : Form
    {
        string currentCalculation;
        char lastDigit, inputDigit;
        bool thereIsANegativeNumber, thereIsAnOpenParentheses, equalsButtonWasPressed;
        
        public MainForm()
        {
            InitializeComponent();
            thereIsANegativeNumber = false;
            thereIsAnOpenParentheses = false;
            equalsButtonWasPressed = false;
            currentCalculation = "";
        }

        private void SetScreen()
        {
            // frmMain width is a 18% of the primary screen
            int width = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.18);
            // frmMain width is a 37% of the primary screen
            int height = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.37);
            // Set frmMain's imutable size
            this.Size = this.MinimumSize = this.MaximumSize =  new Size(width, height);

            //Displays'es width it´s a 76% of frmMain
            width = Convert.ToInt32(this.Size.Width * 0.75);
            this.txtExpression.Width = this.txtResult.Width = width;

            //mainContainer's widht is a 83% of frmMain
            width = Convert.ToInt32(this.Size.Width * 0.83);
            //mainContainer's height is a 81% of frmMain
            height = Convert.ToInt32(this.Size.Height * 0.81);
            mainContainer.Size = new Size(width, height);


            //buttonsContainer's width is a 78% of frmMain
            width = Convert.ToInt32(this.Size.Width * 0.78);
            //buttonsContainer's height is a 58% of frmMain
            height = Convert.ToInt32(this.Size.Height * 0.58);
            // Set buttonsContainer size
            this.buttonsContainer.Size = new Size(width, height);

            //buttons
            width = Convert.ToInt32(this.buttonsContainer.Size.Width * 0.17);
            height = Convert.ToInt32(this.buttonsContainer.Height * 0.21);
            // Set size of all buttons
            button0.Size = button1.Size = button2.Size = button3.Size = button4.Size = button5.Size = button6.Size
                = button7.Size = button8.Size = button9.Size = buttonDecimal.Size = buttonEqual.Size
                = buttonPlus.Size = buttonMinus.Size = buttonMultiplication.Size = buttonDivision.Size
                = buttonOpenBracket.Size = buttonCloseBracket.Size = buttonC.Size = buttonCE.Size = new Size(width, height);
        }

        /// <returns>
        ///        Returns true if the last calculator input is a number and false if it's not.
        /// </returns>
        private bool IsLastDigitANumber()
        {
            bool isANumber = false;
            if (txtExpression.Text.Length > 0)
                if (char.IsNumber(txtExpression.Text[txtExpression.Text.Length-1]))
                    isANumber = true;
            return isANumber;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetScreen();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (equalsButtonWasPressed)
            {
                clear_Button_Click(new object(), new EventArgs());
                equalsButtonWasPressed = false;
            }

            inputDigit = Convert.ToChar((sender as Button).Text);

            if (txtExpression.Text.Length > 0)
                lastDigit = txtExpression.Text[txtExpression.Text.Length-1];

            // ¿Is the input digit a number?
            if (char.IsNumber(inputDigit))
            {
                // It's added as long as there is no parenthesis before it
                if (lastDigit != ')')
                {
                    currentCalculation += inputDigit;
                    txtExpression.Text = currentCalculation;
                }
            }
            else
            {
                // The minus symbol it's added always, there are not condition for it
                if (inputDigit == '-')
                {
                    currentCalculation += inputDigit;
                    txtExpression.Text = currentCalculation;
                }

                // ¿Is the input digit an open parenthesis?
                if (inputDigit == '(')
                {
                    // It is added as long as there is no number before it
                    if (!char.IsNumber(lastDigit))
                    {
                        currentCalculation += inputDigit;
                        txtExpression.Text = currentCalculation;
                        thereIsAnOpenParentheses = true;
                    }
                }
                // ¿Is the input digit a close parenthesis ")"?
                if (inputDigit == ')')
                {
                    // It is added as long as there is an unclosed parenthesis before it
                    if (thereIsAnOpenParentheses)
                    {
                        currentCalculation += inputDigit;
                        txtExpression.Text = currentCalculation;
                        thereIsAnOpenParentheses = false;
                    }
                }
                // Then, if the input digit is an operator (+, -, x or /)
                else
                    if (char.IsNumber(lastDigit) || lastDigit == ')')
                {
                    currentCalculation += inputDigit;
                    txtExpression.Text = currentCalculation;
                }
            }
        }

        private void equals_Button_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.Replace("x", "*");

            try
            {
                txtResult.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation += txtResult.Text;
                txtExpression.Text += "=";
                lastDigit = '=';
                equalsButtonWasPressed = true;
            }
            catch (Exception)
            {
                txtExpression.Text = "0";
                currentCalculation = "";
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            currentCalculation = "";
            txtExpression.Text = "";
            txtResult.Text = "";
        }

        private void clearEntry_Button_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0 && lastDigit != '=')
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
                txtExpression.Text = currentCalculation;
            }
        }
    }
}
