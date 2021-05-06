﻿using System;
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
    public partial class askCarForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Studying3\kursova\CarsCreator\CarsCreator\Database1.mdf;Integrated Security = True");
        public String rez;
        public askCarForm()
        {
            InitializeComponent();
        }

        private void askCarForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmnd = new SqlCommand("Select fname from Cars", con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Console.WriteLine(String.Format("{0}", reader[0]));
                    comboBox1.Items.Add(reader.GetValue(0));
                }
            }
            con.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.rez = comboBox1.Text;
        }
    }
}
