using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppPart2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            User foundUser = VirtualDatabase.Users.Find(m => m.Username == username && m.Password == password);

            if (foundUser != null)
            {
                HomePage homePage = new HomePage(foundUser);
                homePage.Show();
            }
            else
                MessageBox.Show("Istifadeci melumatlari yanlisdir!", "Xeta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MouseToggleEvent(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.BackColor == Color.Yellow)
            {
                textBox.BackColor = Color.White;
            }
            else
            {
                textBox.BackColor = Color.Yellow;
            }
        }

        //private void MouseEnterEvent(object sender, EventArgs e)
        //{
        //    TextBox textBox = (TextBox)sender;
        //    textBox.BackColor = Color.Yellow;
        //}

        //private void MouseLeaveEvent(object sender, EventArgs e)
        //{
        //    TextBox textBox = (TextBox)sender;
        //    textBox.BackColor = Color.White;
        //}
    }
}
