using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkMemoryGame
{
    public partial class MemoryGame : Form
    {
        public MemoryGame()
        {
            InitializeComponent();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(1, 20);
            int sameNum = rand.Next(1, 20);

            for (int i = 1; i <= 20; i++)
            {
                Button buttons = new Button();
                buttons.Name = "button " + i.ToString();
                buttons.Size = new Size(140, 140);
                buttons.UseVisualStyleBackColor = true;
                buttons.BackColor = SystemColors.ControlDark;


                if (number == i || sameNum == i)
                    buttons.Tag = true;
                else
                    buttons.Tag = false;

                buttons.Click += OpenBox;

                memoryGamePanel.Controls.Add(buttons);

            }
        }
        private void OpenBox(object sender, EventArgs e)
        {
            Button clickedButton = ((Button)sender);

            if (clickedButton.Tag != null)
            {
                bool? isBoxMine = (bool)clickedButton.Tag;

                if (isBoxMine == true)
                {
                    clickedButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("button20.BackgroundImage");


                }
                else if (isBoxMine == false)
                {
                    clickedButton.BackColor = Color.Green;
                }
            }
            clickedButton.Tag = null;
        }

    }
}
