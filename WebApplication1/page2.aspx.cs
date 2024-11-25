using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(TextBox1.Text);
            var b = int.Parse(TextBox2.Text);
            var c = DropDownList1.SelectedValue;
            
            if(c == "*")
            {
                Label1.Text = (a * b).ToString();
            }
            else if (c == "/")
            {
                if (b != 0)
                {
                    Label1.Text = (a / b).ToString();
                }
                else
                {
                    Label1.Text = "Ошибка: Деление на 0!";
                }
            }
            else if (c == "+")
            {
                Label1.Text = (a + b).ToString();
            }
            else if (c == "-")
            {
                Label1.Text = (a - b).ToString();
            }
            else
            {
                Label1.Text = "Неизвестная операция.";
            }



        }
    }
}