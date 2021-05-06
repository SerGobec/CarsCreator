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
    
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Studying3\kursova\CarsCreator\CarsCreator\Database1.mdf;Integrated Security = True");
        public carSet carset;
        public Form1()
        {
            carset = new carSet();
            InitializeComponent();
            this.header.MouseDown += new MouseEventHandler((o, e) =>
            {
                header.Capture = false;
                Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref message);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.carset.carter = !this.carset.carter;
            if (carset.carter)
            {
                this.carterPanel.BackgroundImage = global::CarsCreator.Properties.Resources.carC;
            } else
            {
                this.carterPanel.BackgroundImage = global::CarsCreator.Properties.Resources.carG;
            }
        }
        //
        // car panel
        //
        private void car_MouseEnter(object sender, System.EventArgs e)
        {
            this.carPanel.Left -= 5;
            this.carPanel.Width += 10;
        }

        private void car_MouseLeave(object sender, System.EventArgs e)
        {
            this.carPanel.Left += 5;
           // this.carPanel.Top -= 2;
            this.carPanel.Width -= 10;
           // this.carPanel.Height -= 4;
        }

        private void signaling_Click(object sender, EventArgs e)
        {
            this.carset.signal = !this.carset.signal;
            if (carset.signal)
            {
                this.signalingPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sColor;
            }
            else
            {
                this.signalingPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sG;
            }
        }

        private void carPanel_Click(object sender, EventArgs e)
        {
            using (askCarForm askf = new askCarForm())
            {
                if(askf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if(askf.rez != "")
                    {
                        this.carset.model = askf.rez;
                        String path = @"..\\carsModel\" + this.carset.model + ".png";
                        try
                        {
                            Bitmap bmp = new Bitmap(path);
                            carPanel.BackgroundImage = bmp;
                        } catch
                        {
                            carPanel.BackgroundImage = Properties.Resources.car_default;
                        }
                        
                    } else
                    {
                        MessageBox.Show("You have to chose model of car");
                    }                 
                }
            }
            
            /*
            con.Open();
            String comand = "Select photoURL from Cars where fname = " + this.carset.model;
            SqlCommand cmnd = new SqlCommand(comand, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                if (reader.Read())
                {
                    
                    // Console.WriteLine(String.Format("{0}", reader[0])); 
                }
            }
            con.Close();*/
        }

        private void sabPanel_Click_1(object sender, EventArgs e)
        {
            this.carset.sab = !this.carset.sab;
            if (carset.sab)
            {
                this.sabPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sabColor;
            }
            else
            {
                this.sabPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sabGrey;
            }
        }

        private void sitPanel_Click(object sender, EventArgs e)
        {
            this.carset.sit = !this.carset.sit;
            if (carset.sit)
            {
                this.sitPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sitColor;
            }
            else
            {
                this.sitPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sitGrey;
            }
        }

        private void sonarPanel_Click(object sender, EventArgs e)
        {
            this.carset.sonar = !this.carset.sonar;
            if (carset.sonar)
            {
                this.sonarPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sonarC;
            }
            else
            {
                this.sonarPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sonarG;
            }
        }

        private void tvPanel_Click(object sender, EventArgs e)
        {
            this.carset.tv = !this.carset.tv;
            if (carset.tv)
            {
                this.tvPanel.BackgroundImage = global::CarsCreator.Properties.Resources.tvColor;
            }
            else
            {
                this.tvPanel.BackgroundImage = global::CarsCreator.Properties.Resources.tvGrey;
            }
        }

        private void xeonPanel_Click_1(object sender, EventArgs e)
        {
            this.carset.xeon = !this.carset.xeon;
            if (carset.xeon)
            {
                this.xeonPanel.BackgroundImage = global::CarsCreator.Properties.Resources.xC;
            }
            else
            {
                this.xeonPanel.BackgroundImage = global::CarsCreator.Properties.Resources.xG;
            }
        }

        private void diskLabel_Click(object sender, EventArgs e)
        {
            using (choseDisk askd = new choseDisk())
            {
                if (askd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (askd.diskIndex != -1)
                    {
                        this.carset.diskIndex = askd.diskIndex;
                        /*String path = @"..\\carsModel\" + this.carset.model + ".png";
                        try
                        {
                            Bitmap bmp = new Bitmap(path);
                            carPanel.BackgroundImage = bmp;
                        }
                        catch
                        {
                            carPanel.BackgroundImage = Properties.Resources.car_default;
                        }*/
                        this.diskLabel.ImageIndex = carset.diskIndex;
                        this.diskLabel.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("You have to chose model of disk");
                    }
                }
            }
        }
    }

    public class carSet
    {
        public bool carter = false;
        public bool signal = false;
        public bool sab = false;
        public bool sit = false;
        public bool sonar = false;
        public bool tv = false;
        public bool xeon = false;
        public String model = "";
        public int diskIndex = 0;
    } 
}
