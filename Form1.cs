using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string currentText = "+";
        private List<string> flows = new List<string>();
        private bool afterlife = false;


        private void showText(string text)
        {
            if (afterlife)
            {
                textBox1.Text = "";
                afterlife = false;
            }
            if (currentText[0] != '-') {
                teks.Text = text.Substring(1);
            } else if (currentText[0] == '-')
            {
                teks.Text = text;
            }
        }

        public void addToFlows(string identifier)
        {
            if (afterlife)
            {
                textBox1.Text = "";
                afterlife = false;
            }
            flows.Add(currentText);
            if (currentText[0] == '-' && flows.Count == 0)
            {
                textBox1.Text = textBox1.Text + currentText + identifier;
            } else
            {
                textBox1.Text = textBox1.Text + currentText.Substring(1) + identifier;
            }
           
            currentText = identifier;
            teks.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addThree_Click(object sender, EventArgs e)
        {
            currentText += "3";
            showText(currentText);

        }

        private void addTwo_Click(object sender, EventArgs e)
        {
            currentText += "2";
            showText(currentText);
        }

        private void addOne_Click(object sender, EventArgs e)
        {
            currentText += "1";
            showText(currentText);
        }

        private void addFour_Click(object sender, EventArgs e)
        {
            currentText += "4";
            showText(currentText);
        }

        private void addFive_Click(object sender, EventArgs e)
        {
            currentText += "5";
            showText(currentText);
        }

        private void addSix_Click(object sender, EventArgs e)
        {
            currentText += "6";
            showText(currentText);
        }

        private void addSeven_Click(object sender, EventArgs e)
        {
            currentText += "7";
            showText(currentText);
        }

        private void addEight_Click(object sender, EventArgs e)
        {
            currentText += "8";
            showText(currentText);
        }

        private void addNine_Click(object sender, EventArgs e)
        {
            currentText += "9";
            showText(currentText);
        }

        private void addZero_Click(object sender, EventArgs e)
        {
            currentText += "0";
            showText(currentText);
        }

        private void addMultileZero_Click(object sender, EventArgs e)
        {
            currentText += "00";
            showText(currentText);
        }

        private void commas_Click(object sender, EventArgs e)
        {
            if (currentText.Length > 1)
            {
                currentText += ".";
                showText(currentText);
            }
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            if (currentText.Length > 1)
            {
                addToFlows("+");
            }
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            if (currentText.Length > 1)
            {
                addToFlows("-");
            } else if (currentText.Length == 1 && flows.Count == 0)
            {
                currentText = "-";
                teks.Text = "-";
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (currentText.Length > 1)
            {
                addToFlows("/");
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (currentText.Length > 1)
            {
                addToFlows("*");
            }
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            flows.Clear();
            currentText = "+";
            teks.Text = "";
            textBox1.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            currentText = "+";
            teks.Text = "";
        }
         
        private void resultButton_Click(object sender, EventArgs e)
        {
            flows.Add(currentText);
            if (string.Join("", flows)[0] == '-')
            {
                textBox1.Text = string.Join("", flows);

            }
            else
            {
                textBox1.Text = string.Join("", flows).Substring(1);
            }

            string expression = string.Join("", flows).Replace("X", "*");
            if (!char.IsDigit(expression[expression.Length - 1]))
            {
                expression = expression.Substring(0, expression.Length - 1);
            }

            DataTable dt = new DataTable();
            var result = dt.Compute(expression, "");

            currentText = $"+{result}".Replace(",", ".");
            teks.Text = currentText.Substring(1);

            flows.Clear();
            afterlife = true;

        }
        private void teks_TextChanged(object sender, EventArgs e)
        {
        }
        private void delButton_Click(object sender, EventArgs e)
        {
            if (currentText.Length > 1)
            {
                currentText = currentText.Substring(0, currentText.Length - 1);
                showText(currentText);
            }
        }

        private void teks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Riwayat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
