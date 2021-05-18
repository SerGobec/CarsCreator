using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarsCreator.Services;

namespace CarsCreator
{
    public partial class choseDisk : Form
    {
        //  AttachDbFilename=C:\Studying3\kursova\CarsCreator\CarsCreator\Database1.mdf
        //
        // public String wayto;
        SqlService sqlservice;
        public int diskIndex = 0;
        public choseDisk()
        {
            sqlservice = new SqlService();
           // MessageBox.Show(wayto);
           // wayto = Application.StartupPath + "\\Database1.mdf";  
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            diskIndex += 1;
            if(diskIndex > 13)
            {
                diskIndex = 0;
            }
            label2.Text = sqlservice.GetPriceOfDiskbyIndex(diskIndex)+"$";     
            this.disk.ImageIndex = diskIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            diskIndex -= 1;
            if (diskIndex < 0)
            {
                diskIndex = 13;
            }
            label2.Text = sqlservice.GetPriceOfDiskbyIndex(diskIndex) + "$";
            this.disk.ImageIndex = diskIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
