using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            exit_button.BackColor = Color.Red;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.BackColor = Color.Gray;
        }

        private void button_equal_MouseEnter(object sender, EventArgs e)
        {
            button_equal.BackColor = Color.DodgerBlue;
        }

        private void button_equal_MouseLeave(object sender, EventArgs e)
        {
            button_equal.BackColor = Color.LightSkyBlue;
        }

        private void button_pos_negative_MouseEnter(object sender, EventArgs e)
        {
            button_pos_negative.BackColor = Color.Gray;
        }

        private void button_pos_negative_MouseLeave(object sender, EventArgs e)
        {
            button_pos_negative.BackColor = Color.White;
        }

        private void button_zero_MouseEnter(object sender, EventArgs e)
        {
            button_zero.BackColor = Color.Gray;
        }

        private void button_zero_MouseLeave(object sender, EventArgs e)
        {
            button_zero.BackColor = Color.White;
        }

        private void button_comma_MouseEnter(object sender, EventArgs e)
        {
            button_comma.BackColor = Color.Gray;
        }

        private void button_comma_MouseLeave(object sender, EventArgs e)
        {
            button_comma.BackColor = Color.White;
        }

        private void button_one_MouseEnter(object sender, EventArgs e)
        {
            button_one.BackColor = Color.Gray;
        }

        private void button_one_MouseLeave(object sender, EventArgs e)
        {
            button_one.BackColor = Color.White;
        }

        private void button_two_MouseEnter(object sender, EventArgs e)
        {
            button_two.BackColor = Color.Gray;
        }

        private void button_two_MouseLeave(object sender, EventArgs e)
        {
            button_two.BackColor = Color.White;
        }

        private void button_three_MouseEnter(object sender, EventArgs e)
        {
            button_three.BackColor = Color.Gray;
        }

        private void button_three_MouseLeave(object sender, EventArgs e)
        {
            button_three.BackColor = Color.White;
        }

        private void button_four_MouseEnter(object sender, EventArgs e)
        {
            button_four.BackColor = Color.Gray;
        }

        private void button_four_MouseLeave(object sender, EventArgs e)
        {
            button_four.BackColor = Color.White;
        }

        private void button_five_MouseEnter(object sender, EventArgs e)
        {
            button_five.BackColor = Color.Gray;
        }

        private void button_five_MouseLeave(object sender, EventArgs e)
        {
            button_five.BackColor = Color.White;
        }

        private void button_six_MouseEnter(object sender, EventArgs e)
        {
            button_six.BackColor = Color.Gray;
        }

        private void button_six_MouseLeave(object sender, EventArgs e)
        {
            button_six.BackColor = Color.White;
        }

        private void button_seven_MouseEnter(object sender, EventArgs e)
        {
            button_seven.BackColor = Color.Gray;
        }

        private void button_seven_MouseLeave(object sender, EventArgs e)
        {
            button_seven.BackColor = Color.White;
        }

        private void button_eight_MouseEnter(object sender, EventArgs e)
        {
            button_eight.BackColor = Color.Gray;
        }

        private void button_eight_MouseLeave(object sender, EventArgs e)
        {
            button_eight.BackColor = Color.White;
        }

        private void button_nine_MouseEnter(object sender, EventArgs e)
        {
            button_nine.BackColor = Color.Gray;
        }

        private void button_nine_MouseLeave(object sender, EventArgs e)
        {
            button_nine.BackColor = Color.White;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationPerformed))
                textBox_result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_result.Text += button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            if (resultValue != 0)
            {
                button_equal.PerformClick
            }
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = double.Parse(textBox_result.Text);
            label_result.Text = resultValue  + " " + operationPerformed;
            isOperationPerformed = true;
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {            
            switch (operationPerformed)
            {
                case "+":
                    label_result.Text = resultValue + " + " + textBox_result.Text + " = ";
                    textBox_result.Text = (resultValue + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    label_result.Text = resultValue + " - " + textBox_result.Text + " = ";
                    textBox_result.Text = (resultValue - double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    label_result.Text = resultValue + " x " + textBox_result.Text + " = ";
                    textBox_result.Text = (resultValue * double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    label_result.Text = resultValue + " / " + textBox_result.Text + " = ";
                    textBox_result.Text = (resultValue / double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            label_result.Text = "0";
        }
    }
}
