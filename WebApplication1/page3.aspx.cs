using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static double _firstNumber = 0;
        private static double _secondNumber = 0;
        private static string _operation = string.Empty;
        private static bool _isResultDisplayed = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Num_Click(object sender, EventArgs e)
        {
                Button button = (Button)sender;
            if (_isResultDisplayed)
            {
                TextBox1.Text = string.Empty;
                _isResultDisplayed = false;
            }
                TextBox1.Text += button.Text;
        }

        protected void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (double.TryParse(TextBox1.Text, out double result))
            {
                _firstNumber = result;
                _operation = button.Text;
                TextBox1.Text += " " + _operation + " ";
            }
            else {
                TextBox1.Text = "Ошибка";
            }
        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            string[] parts = TextBox1.Text.Split(' ');

            if (parts.Length == 3 &&
                double.TryParse(parts[2], out _secondNumber))
            {
                double result = 0;
                switch (_operation)
                {
                    case "+":
                        result = _firstNumber + _secondNumber;
                        break;
                    case "-":
                        result = _firstNumber - _secondNumber;
                        break;
                    case "*":
                        result = _firstNumber * _secondNumber;
                        break;
                    case "/":
                        result = _secondNumber != 0 ? _firstNumber / _secondNumber : double.NaN;
                        break;
                    default:
                        TextBox1.Text = "Ошибка!";
                        return;
                }

                TextBox1.Text = result.ToString(); 
                _secondNumber = 0;
                _operation = string.Empty;
                _isResultDisplayed = true;
            }
            else
            {
                TextBox1.Text = "Ошибка!";
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = string.Empty;
            _isResultDisplayed = false;
            TextBox1.Text = string.Empty;

        }
    }
}