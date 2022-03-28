using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAsTurbo
{
    public partial class VerifyNumber : Form
    {
        public VerifyNumber()
        {
            InitializeComponent();
        }

        private void VerifyNumber_Load(object sender, EventArgs e)
        {
            label_getNumber.Text = EnterCabinet.passingNumber + "  Nömrəsinə SMS-kod göndərildi.";
        }

        private void button_verify_Click(object sender, EventArgs e)
        {

            if (textBox_verifyOTP.Text == EnterCabinet.otpCode)
            {
                WEB login = new WEB();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("OTP kodu səhvdir!");
            }

        }
    }
}
