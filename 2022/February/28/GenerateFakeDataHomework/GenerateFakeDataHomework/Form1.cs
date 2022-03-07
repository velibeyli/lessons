using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GenerateFakeDataHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GeneratePersonBtn_Click(object sender, EventArgs e)
        {
            VirtualDatabase db = new VirtualDatabase();
            List<Person> person = db.GetPerson(1000);            

            dataGridViewGeneratePerson.DataSource = person;

            Log(person,true);
        }
        private void Log(List<Person> prsn, bool isAdded)
        {
            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person();

                FileStream filestream = null;

                person.Id = (int)dataGridViewGeneratePerson[0, i].Value;
                person.Name = (string)dataGridViewGeneratePerson[1, i].Value;
                person.Surname = (string)dataGridViewGeneratePerson[2, i].Value;
                person.Email = (string)dataGridViewGeneratePerson[3, i].Value;
                person.Country = (string)dataGridViewGeneratePerson[4, i].Value;

                string countryName = person.Country + "/";
                var fileName = person.Name + " " + person.Surname + ".txt";

                if (!Directory.Exists(GlobalSettings.LOGS_PATH + countryName))
                    Directory.CreateDirectory(GlobalSettings.LOGS_PATH + countryName);

                if (!File.Exists(GlobalSettings.LOGS_PATH + countryName + fileName))
                    filestream = File.Create(GlobalSettings.LOGS_PATH + countryName + fileName);

                if (filestream != null)
                    filestream.Close();


                if (person.Country.Contains(person.Country))
                {
                    List<string> logDetails = new List<string>()
                    {
                    "---------------------------------------------" + (isAdded ? "Added" : "Not added") + " at " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:ms"),
                    "Id: " + person.Id,
                    "Name: " + person.Name,
                    "Surname: " + person.Surname,
                    "Email: " + person.Email,
                    "Country: " + person.Country,
                    "---------------------------------------------END",
                    " "
                    };

                    File.AppendAllLines(GlobalSettings.LOGS_PATH + countryName + fileName, logDetails);

                    
                }
            }
        }

        private void PersonStatisticBtn_Click(object sender, EventArgs e)
        {
            Statistics statisticForm = new Statistics();
            statisticForm.Show();
        }
    }
}
