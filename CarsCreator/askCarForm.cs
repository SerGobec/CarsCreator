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
    public partial class askCarForm : Form
    {
        SqlService sqlservice;
        public String rez;
        public askCarForm()
        {
            sqlservice = new SqlService();
            InitializeComponent();
        }

        private void askCarForm_Load(object sender, EventArgs e)
        {
            List<string> names = sqlservice.GetNames();
            for(int i = 0;i < names.Count; i++)
            {
                comboBox1.Items.Add(names[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.rez = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rez = comboBox1.Text;
            String path = @"..\\carsModel\" + this.comboBox1.Text + ".png";
            try
            {

                Bitmap bmp = new Bitmap(path);
                smallCarPanel.BackgroundImage = bmp;

            }
            catch
            {
                smallCarPanel.BackgroundImage = Properties.Resources.car_default;
            }
        }
    }
}
