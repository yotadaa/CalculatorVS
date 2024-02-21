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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void addZero_Click(object sender, EventArgs e)
        {
            if (currentText != "")
            {
                currentText += "0";
            }
        }

        private void addMultileZero_Click(object sender, EventArgs e)
        {
            if (currentText != "")
            {
                currentText += "00";
            }
        }

        private void commas_Click(object sender, EventArgs e)
        {
            if (currentText != "")
            {
                currentText += ".";
            }
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            if (currentText != "")
            {
                flows.Add('+'+currentText);
            }
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            if (currentText != "")
            {
                flows.Add('-' + currentText);
            }
        }

        private void addThree_Click(object sender, EventArgs e)
        {

        }

        private void addTwo_Click(object sender, EventArgs e)
        {

        }

        private void addOne_Click(object sender, EventArgs e)
        {
        }

        private void addFour_Click(object sender, EventArgs e)
        {

        }

        private void addFive_Click(object sender, EventArgs e)
        {

        }

        private void addSix_Click(object sender, EventArgs e)
        {

        }

        private void addSeven_Click(object sender, EventArgs e)
        {

        }

        private void addEight_Click(object sender, EventArgs e)
        {

        }

        private void addNine_Click(object sender, EventArgs e)
        {

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (currentText != "")
            {
                flows.Add('/' + currentText);
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (currentText != "")
            {
                flows.Add('*' + currentText);
            }
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            flows.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            currentText = "";
        }

        private void resultButton_Click(object sender, EventArgs e)
        {

        }

        private void teks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
