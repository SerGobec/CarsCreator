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

namespace CarsCreator
{
    public partial class choseDisk : Form
    {
        //  AttachDbFilename=C:\Studying3\kursova\CarsCreator\CarsCreator\Database1.mdf
        //
        // public String wayto;
        String strConnection;
        SqlConnection con;
        public int diskIndex = 0;
        public choseDisk()
        {
           // MessageBox.Show(wayto);
           // wayto = Application.StartupPath + "\\Database1.mdf";
            strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Database1.mdf"  + ";Integrated Security = True";
            con = new SqlConnection(strConnection);      
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            diskIndex += 1;
            if(diskIndex > 13)
            {
                diskIndex = 0;
            }
            con.Open();
            String cmndStr = "Select price from DiskPrice where idDisk = " + diskIndex;
            SqlCommand cmnd = new SqlCommand(cmndStr, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Console.WriteLine(String.Format("{0}", reader[0]));
                    label2.Text = (int)reader.GetValue(0) + "$";
                }
            }
            con.Close();
            this.disk.ImageIndex = diskIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            diskIndex -= 1;
            if (diskIndex < 0)
            {
                diskIndex = 13;
            }
            con.Open();
            String cmndStr = "Select price from DiskPrice where idDisk = " + diskIndex;
            SqlCommand cmnd = new SqlCommand(cmndStr, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Console.WriteLine(String.Format("{0}", reader[0]));
                    label2.Text = (int)reader.GetValue(0) + "$";
                }
            }
            con.Close();
            this.disk.ImageIndex = diskIndex;
        }
    }
}
