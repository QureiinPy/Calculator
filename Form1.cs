using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;

namespace Сalculator
{
    public partial class Form1 : Form
    {

        private int value1, value2;
        private string res;
        private string str_operator;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Input.Text += button.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Input.Clear();
            ViewOperation.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(Input.Text);
            Input.Text = "";
            ViewOperation.Text = "-";
            str_operator = "-";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(Input.Text);
            Input.Text = "";
            ViewOperation.Text = "+";
            str_operator = "+";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(Input.Text);
            Input.Text = "";
            ViewOperation.Text = "×";
            str_operator = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(Input.Text);
            Input.Text = "";
            ViewOperation.Text = "÷";
            str_operator = "/";
        }

        private void result_Click(object sender, EventArgs e)
        {
            try
            {
                value2 = int.Parse(Input.Text);

                if (str_operator == "-")
                    res = (value1 - value2).ToString();

                if (str_operator == "+")
                    res = (value1 + value2).ToString();
                
                if(str_operator == "/")
                    res = (value1 / value2).ToString();

                if(str_operator == "*")
                    res = (value1 * value2).ToString();
                Input.Text = res;
                ViewOperation.Text = "";
            }
            catch (FormatException)
            {
                Input.Text = "Пустое поле!";
            }
             
        }

    }
}