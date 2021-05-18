using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsCreator.Services;

namespace CarsCreator
{
    public partial class OpenSevedCar : Form
    {
        StreamService streamservice;
        public OpenSevedCar()
        {  
            streamservice = new StreamService();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // What can I do than else?
        }

        private void OpenSevedCar_Load(object sender, EventArgs e)
        {
            string actual = streamservice.ReadModels();
            string[] mas = actual.Split('\n');
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = mas[i].Replace("\r","");
                string[] model = mas[i].Split(';');
                if (mas[i] != "")
                {
                    this.savedBox.Items.Add(model[0] + ". "+ model[1] + "h.p.");
                }
            }
            this.savedBox.SelectedIndex = 0;
        }

        public int GetBoxIndex()
        {
            return this.savedBox.SelectedIndex;
        }
    }
}
