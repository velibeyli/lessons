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

namespace GenerateFakeDataHomework
{
    public partial class Statistics : Form
    {


        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {            
            //int directoryCount = Directory.GetDirectories(GlobalSettings.LOGS_PATH).Count();

            DirectoryInfo dirInfo = new DirectoryInfo(GlobalSettings.LOGS_PATH);

            DirectoryInfo[] directories = dirInfo.GetDirectories();

            /*foreach (var item in directories)                 //ustunde 1 saat basimi agritdigim alinmayan loop
            {

                var query = directories.Select(i => new          
                {
                    Country = item.Name,
                    PeopleCount = item.GetFiles().Count()
                }).ToList();


               dataGridView_statistic.DataSource = query;
            }
            */

            var query2 = directories.Select(i => new
            {
                Country = i.Name,
                PeopleCount = i.GetFiles().Count()
            }).ToList();

            dataGridView_statistic.DataSource = query2;
        }
    }
}
