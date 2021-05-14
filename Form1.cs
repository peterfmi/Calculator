using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        private double memory;
        private bool memFlag;

        public Form1()
        {
            InitializeComponent();
            buttonMC.Enabled = false;
            buttonMR.Enabled = false;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed) || memFlag==true)
                textBox_Result.Clear();
            isOperationPerformed = false;
            memFlag = false;
            Button button=(Button)sender;
            if(button.Text==".")
            {
                if (!textBox_Result.Text.Contains("."))
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerformed = button.Text;
                labelOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text, CultureInfo.InvariantCulture);
                labelOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        //Clear Entry (CE) Button
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        //Clear All (C) Button
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            labelOperation.Text = "";
            resultValue = 0; 
        }

        //Equal Button
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;               
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelOperation.Text = "";
        }

        //Delete Button
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1);
            if (textBox_Result.Text.Length == 0)
                textBox_Result.Text = "0";
        }

        //Sqrt Button
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            labelOperation.Text = "√(" + textBox_Result.Text + ")";
            textBox_Result.Text = Math.Sqrt(Double.Parse(textBox_Result.Text)).ToString();
        }

        //Sqr Button
        private void buttonSqr_Click(object sender, EventArgs e)
        {
            labelOperation.Text = "(" + textBox_Result.Text + ")²";
            textBox_Result.Text = (Double.Parse(textBox_Result.Text) * Double.Parse(textBox_Result.Text)).ToString();
        }

        //Recip Button
        private void buttonRecip_Click(object sender, EventArgs e)
        {
            labelOperation.Text = "1/(" + textBox_Result.Text + ")";
            textBox_Result.Text = (1/Double.Parse(textBox_Result.Text)).ToString();
        }

        //Percent Button
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            labelOperation.Text = "" + textBox_Result.Text + "%";
            textBox_Result.Text = (Double.Parse(textBox_Result.Text)/100).ToString();
        }

        //Memory Save
        private void buttonMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(textBox_Result.Text);
            buttonMC.Enabled = true;
            buttonMR.Enabled = true;
            memFlag = true;
        }

        //Memory Read
        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = memory.ToString();
            memFlag = true;
        }

        //Memory Clear
        private void buttonMC_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            memory = 0;
            buttonMR.Enabled = false;
            buttonMC.Enabled = false;
        }

        //Memory Plus
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(textBox_Result.Text);
        }

        //Memory Minus
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(textBox_Result.Text);
        }
    }
}