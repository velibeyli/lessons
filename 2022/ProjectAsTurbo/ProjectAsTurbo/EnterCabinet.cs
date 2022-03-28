using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAsTurbo
{
    public partial class EnterCabinet : Form
    {
        public static string passingNumber;
        public static string otpCode;

        public EnterCabinet()
        {
            InitializeComponent();
        }

        private void textBox_enterPhoneNum_TextChanged(object sender, EventArgs e)
        {
            if (textBox_enterPhoneNum.Text.Length == 10)
                button_sendSMS.Enabled = true;
            else
                button_sendSMS.Enabled = false;
        }

        private void button_sendSMS_Click(object sender, EventArgs e)
        {
            passingNumber = textBox_enterPhoneNum.Text;
            VerifyNumber verifyNum = new VerifyNumber();
            verifyNum.Show();
            OutboxSMSLog();
            this.Close();
        }
        private void OutboxSMSLog()
        {
            Random randomSMS = new Random();
            var smsCode = randomSMS.Next(1000, 9000);

            FileStream fileStream = null;
            var fileName = passingNumber + "_OTPMessage.txt";

            if (!Directory.Exists(GlobalSettings.OutboxMessage_Path))
                Directory.CreateDirectory(GlobalSettings.OutboxMessage_Path);

            if (!File.Exists(GlobalSettings.OutboxMessage_Path + fileName))
                fileStream = File.Create(GlobalSettings.OutboxMessage_Path + fileName);
            else if(File.Exists(GlobalSettings.OutboxMessage_Path + fileName))
            {
                File.Delete(GlobalSettings.OutboxMessage_Path + fileName);
                fileStream = File.Create(GlobalSettings.OutboxMessage_Path + fileName);
            }

            if (fileStream != null)
                fileStream.Close();

            string outboxSMSDetails = "\n" + passingNumber + " nin OTP kodu " + smsCode;
            File.AppendAllText(GlobalSettings.OutboxMessage_Path + fileName, outboxSMSDetails);

            WEB.passingUser = passingNumber.ToString();
            CreateAdvertisement.passingUser = passingNumber.ToString();
            DetailedSearch.passingUser = passingNumber.ToString();

            otpCode = smsCode.ToString();
        }
    }
}
