
namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.maximize_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.Button();
            this.button_pos_negative = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_comma = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_one = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_seven = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_devide = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.button_reverse = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(301, -1);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(48, 31);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseEnter += new System.EventHandler(this.exit_button_MouseEnter);
            this.exit_button.MouseLeave += new System.EventHandler(this.exit_button_MouseLeave);
            // 
            // maximize_button
            // 
            this.maximize_button.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_button.Location = new System.Drawing.Point(254, -1);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Size = new System.Drawing.Size(48, 31);
            this.maximize_button.TabIndex = 2;
            this.maximize_button.Text = "M";
            this.maximize_button.UseVisualStyleBackColor = true;
            // 
            // minimize_button
            // 
            this.minimize_button.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.Location = new System.Drawing.Point(207, -1);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(48, 31);
            this.minimize_button.TabIndex = 3;
            this.minimize_button.Text = "-";
            this.minimize_button.UseVisualStyleBackColor = true;
            // 
            // button_pos_negative
            // 
            this.button_pos_negative.BackColor = System.Drawing.Color.White;
            this.button_pos_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pos_negative.Location = new System.Drawing.Point(1, 474);
            this.button_pos_negative.Name = "button_pos_negative";
            this.button_pos_negative.Size = new System.Drawing.Size(86, 54);
            this.button_pos_negative.TabIndex = 6;
            this.button_pos_negative.Text = "+/-";
            this.button_pos_negative.UseVisualStyleBackColor = false;
            this.button_pos_negative.MouseEnter += new System.EventHandler(this.button_pos_negative_MouseEnter);
            this.button_pos_negative.MouseLeave += new System.EventHandler(this.button_pos_negative_MouseLeave);
            // 
            // button_zero
            // 
            this.button_zero.BackColor = System.Drawing.Color.White;
            this.button_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_zero.Location = new System.Drawing.Point(87, 474);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(86, 54);
            this.button_zero.TabIndex = 7;
            this.button_zero.Text = "0";
            this.button_zero.UseVisualStyleBackColor = false;
            this.button_zero.Click += new System.EventHandler(this.button_click);
            this.button_zero.MouseEnter += new System.EventHandler(this.button_zero_MouseEnter);
            this.button_zero.MouseLeave += new System.EventHandler(this.button_zero_MouseLeave);
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_equal.Location = new System.Drawing.Point(259, 474);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(86, 54);
            this.button_equal.TabIndex = 9;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            this.button_equal.MouseEnter += new System.EventHandler(this.button_equal_MouseEnter);
            this.button_equal.MouseLeave += new System.EventHandler(this.button_equal_MouseLeave);
            // 
            // button_comma
            // 
            this.button_comma.BackColor = System.Drawing.Color.White;
            this.button_comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_comma.Location = new System.Drawing.Point(173, 474);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(86, 54);
            this.button_comma.TabIndex = 8;
            this.button_comma.Text = ".";
            this.button_comma.UseVisualStyleBackColor = false;
            this.button_comma.Click += new System.EventHandler(this.button_click);
            this.button_comma.MouseEnter += new System.EventHandler(this.button_comma_MouseEnter);
            this.button_comma.MouseLeave += new System.EventHandler(this.button_comma_MouseLeave);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.SystemColors.Control;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_plus.Location = new System.Drawing.Point(259, 421);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(86, 54);
            this.button_plus.TabIndex = 13;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.operator_click);
            // 
            // button_three
            // 
            this.button_three.BackColor = System.Drawing.Color.White;
            this.button_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_three.Location = new System.Drawing.Point(173, 421);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(86, 54);
            this.button_three.TabIndex = 12;
            this.button_three.Text = "3";
            this.button_three.UseVisualStyleBackColor = false;
            this.button_three.Click += new System.EventHandler(this.button_click);
            this.button_three.MouseEnter += new System.EventHandler(this.button_three_MouseEnter);
            this.button_three.MouseLeave += new System.EventHandler(this.button_three_MouseLeave);
            // 
            // button_two
            // 
            this.button_two.BackColor = System.Drawing.Color.White;
            this.button_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_two.Location = new System.Drawing.Point(87, 421);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(86, 54);
            this.button_two.TabIndex = 11;
            this.button_two.Text = "2";
            this.button_two.UseVisualStyleBackColor = false;
            this.button_two.Click += new System.EventHandler(this.button_click);
            this.button_two.MouseEnter += new System.EventHandler(this.button_two_MouseEnter);
            this.button_two.MouseLeave += new System.EventHandler(this.button_two_MouseLeave);
            // 
            // button_one
            // 
            this.button_one.BackColor = System.Drawing.Color.White;
            this.button_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_one.Location = new System.Drawing.Point(1, 421);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(86, 54);
            this.button_one.TabIndex = 10;
            this.button_one.Text = "1";
            this.button_one.UseVisualStyleBackColor = false;
            this.button_one.Click += new System.EventHandler(this.button_click);
            this.button_one.MouseEnter += new System.EventHandler(this.button_one_MouseEnter);
            this.button_one.MouseLeave += new System.EventHandler(this.button_one_MouseLeave);
            // 
            // button_multiplication
            // 
            this.button_multiplication.BackColor = System.Drawing.SystemColors.Control;
            this.button_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_multiplication.Location = new System.Drawing.Point(259, 315);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(86, 54);
            this.button_multiplication.TabIndex = 21;
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = false;
            this.button_multiplication.Click += new System.EventHandler(this.operator_click);
            // 
            // button_nine
            // 
            this.button_nine.BackColor = System.Drawing.Color.White;
            this.button_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_nine.Location = new System.Drawing.Point(173, 315);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(86, 54);
            this.button_nine.TabIndex = 20;
            this.button_nine.Text = "9";
            this.button_nine.UseVisualStyleBackColor = false;
            this.button_nine.Click += new System.EventHandler(this.button_click);
            this.button_nine.MouseEnter += new System.EventHandler(this.button_nine_MouseEnter);
            this.button_nine.MouseLeave += new System.EventHandler(this.button_nine_MouseLeave);
            // 
            // button_eight
            // 
            this.button_eight.BackColor = System.Drawing.Color.White;
            this.button_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_eight.Location = new System.Drawing.Point(87, 315);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(86, 54);
            this.button_eight.TabIndex = 19;
            this.button_eight.Text = "8";
            this.button_eight.UseVisualStyleBackColor = false;
            this.button_eight.Click += new System.EventHandler(this.button_click);
            this.button_eight.MouseEnter += new System.EventHandler(this.button_eight_MouseEnter);
            this.button_eight.MouseLeave += new System.EventHandler(this.button_eight_MouseLeave);
            // 
            // button_seven
            // 
            this.button_seven.BackColor = System.Drawing.Color.White;
            this.button_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seven.Location = new System.Drawing.Point(1, 315);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(86, 54);
            this.button_seven.TabIndex = 18;
            this.button_seven.Text = "7";
            this.button_seven.UseVisualStyleBackColor = false;
            this.button_seven.Click += new System.EventHandler(this.button_click);
            this.button_seven.MouseEnter += new System.EventHandler(this.button_seven_MouseEnter);
            this.button_seven.MouseLeave += new System.EventHandler(this.button_seven_MouseLeave);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.SystemColors.Control;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_minus.Location = new System.Drawing.Point(259, 368);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(86, 54);
            this.button_minus.TabIndex = 17;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.operator_click);
            // 
            // button_six
            // 
            this.button_six.BackColor = System.Drawing.Color.White;
            this.button_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_six.Location = new System.Drawing.Point(173, 368);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(86, 54);
            this.button_six.TabIndex = 16;
            this.button_six.Text = "6";
            this.button_six.UseVisualStyleBackColor = false;
            this.button_six.Click += new System.EventHandler(this.button_click);
            this.button_six.MouseEnter += new System.EventHandler(this.button_six_MouseEnter);
            this.button_six.MouseLeave += new System.EventHandler(this.button_six_MouseLeave);
            // 
            // button_five
            // 
            this.button_five.BackColor = System.Drawing.Color.White;
            this.button_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_five.Location = new System.Drawing.Point(87, 368);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(86, 54);
            this.button_five.TabIndex = 15;
            this.button_five.Text = "5";
            this.button_five.UseVisualStyleBackColor = false;
            this.button_five.Click += new System.EventHandler(this.button_click);
            this.button_five.MouseEnter += new System.EventHandler(this.button_five_MouseEnter);
            this.button_five.MouseLeave += new System.EventHandler(this.button_five_MouseLeave);
            // 
            // button_four
            // 
            this.button_four.BackColor = System.Drawing.Color.White;
            this.button_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_four.Location = new System.Drawing.Point(1, 368);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(86, 54);
            this.button_four.TabIndex = 14;
            this.button_four.Text = "4";
            this.button_four.UseVisualStyleBackColor = false;
            this.button_four.Click += new System.EventHandler(this.button_click);
            this.button_four.MouseEnter += new System.EventHandler(this.button_four_MouseEnter);
            this.button_four.MouseLeave += new System.EventHandler(this.button_four_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button2.Location = new System.Drawing.Point(259, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 54);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button3.Location = new System.Drawing.Point(173, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 54);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button4.Location = new System.Drawing.Point(87, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 54);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 54);
            this.button5.TabIndex = 26;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button_devide
            // 
            this.button_devide.BackColor = System.Drawing.SystemColors.Control;
            this.button_devide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_devide.Location = new System.Drawing.Point(259, 262);
            this.button_devide.Name = "button_devide";
            this.button_devide.Size = new System.Drawing.Size(86, 54);
            this.button_devide.TabIndex = 25;
            this.button_devide.Text = "/";
            this.button_devide.UseVisualStyleBackColor = false;
            this.button_devide.Click += new System.EventHandler(this.operator_click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.Control;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_clear.Location = new System.Drawing.Point(173, 262);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(86, 54);
            this.button_clear.TabIndex = 24;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_square
            // 
            this.button_square.BackColor = System.Drawing.SystemColors.Control;
            this.button_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button_square.Location = new System.Drawing.Point(87, 262);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(86, 54);
            this.button_square.TabIndex = 23;
            this.button_square.Text = "CE";
            this.button_square.UseVisualStyleBackColor = false;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // button_reverse
            // 
            this.button_reverse.BackColor = System.Drawing.SystemColors.Control;
            this.button_reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reverse.Location = new System.Drawing.Point(1, 262);
            this.button_reverse.Name = "button_reverse";
            this.button_reverse.Size = new System.Drawing.Size(86, 54);
            this.button_reverse.TabIndex = 22;
            this.button_reverse.UseVisualStyleBackColor = false;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_result.Location = new System.Drawing.Point(6, 81);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(24, 25);
            this.label_result.TabIndex = 30;
            this.label_result.Text = "0";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(8, 142);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(333, 20);
            this.textBox_result.TabIndex = 31;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 531);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_devide);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_square);
            this.Controls.Add(this.button_reverse);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_nine);
            this.Controls.Add(this.button_eight);
            this.Controls.Add(this.button_seven);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_six);
            this.Controls.Add(this.button_five);
            this.Controls.Add(this.button_four);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_one);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_comma);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.button_pos_negative);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.maximize_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button maximize_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button button_pos_negative;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_comma;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_three;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_nine;
        private System.Windows.Forms.Button button_eight;
        private System.Windows.Forms.Button button_seven;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_six;
        private System.Windows.Forms.Button button_five;
        private System.Windows.Forms.Button button_four;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_devide;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_reverse;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

