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
        SqlConnection con;
        String strConnection;
        public carSet carset;
        public Form1()
        {
            strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Database1.mdf" + ";Integrated Security = True";
            con = new SqlConnection(strConnection);
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
                this.carterP.Text = "+ 115$";
                this.carterP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));           
                this.carterP.ForeColor= System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.carterPanel.BackgroundImage = global::CarsCreator.Properties.Resources.carC;
            } else
            {
                this.carterPanel.BackgroundImage = global::CarsCreator.Properties.Resources.carG;
                this.carterP.Text = "no";
                this.carterP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.carterP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
                this.SignalP.Text = "+ 203$";
                this.SignalP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.SignalP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.signalingPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sColor;
            }
            else
            {
                this.signalingPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sG;
                this.SignalP.Text = "no";
                this.SignalP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.SignalP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
                        this.ModelLabelInfo.Text = this.carset.model;
                        this.ModelLabelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
                       
                        this.engineBox.Items.Clear();
                        con.Open();
                        int carsID = -1;
                        //String cmndStr = "Select engineValue from CarsGeneration where carsID = " + carsID;
                        String cmndStr = "Select id from Cars where fName = \'" + carset.model + "\'";
                        SqlCommand cmnd = new SqlCommand(cmndStr, con);
                        using (SqlDataReader reader = cmnd.ExecuteReader())
                        {
                            if (reader.Read())
                            {  
                                carsID = (int)reader.GetValue(0);
                            }
                        }
                        cmndStr = "Select engineValue from CarsGeneration where carsID = " + carsID;
                        cmnd = new SqlCommand(cmndStr, con);
                        using (SqlDataReader reader = cmnd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                engineBox.Items.Add(reader.GetValue(0));
                            }
                        }
                        con.Close();
                        this.engineBox.Visible = true;
                        this.label3.Visible = true;
                        this.priceEngineLabel.Visible = false;
                        this.carset.priceWithEngine = 0;
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
                this.AudioP.Text = "+ 55$";
                this.AudioP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.AudioP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.sabPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sabColor;
            }
            else
            {
                this.sabPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sabGrey;
                this.AudioP.Text = "no";
                this.AudioP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.AudioP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private void sitPanel_Click(object sender, EventArgs e)
        {
            this.carset.sit = !this.carset.sit;
            if (carset.sit)
            {
                this.HeatingP.Text = "+ 72$";
                this.HeatingP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.HeatingP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.sitPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sitColor;
            }
            else
            {
                this.sitPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sitGrey;
                this.HeatingP.Text = "no";
                this.HeatingP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.HeatingP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private void sonarPanel_Click(object sender, EventArgs e)
        {
            this.carset.sonar = !this.carset.sonar;
            if (carset.sonar)
            {
                this.ParkP.Text = "+ 90$";
                this.ParkP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.ParkP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.sonarPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sonarC;
            }
            else
            {
                this.sonarPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sonarG;
                this.ParkP.Text = "no";
                this.ParkP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.ParkP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private void tvPanel_Click(object sender, EventArgs e)
        {
            this.carset.tv = !this.carset.tv;
            if (carset.tv)
            {
                this.TVP.Text = "+ 232$";
                this.TVP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.TVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.tvPanel.BackgroundImage = global::CarsCreator.Properties.Resources.tvColor;
            }
            else
            {
                this.tvPanel.BackgroundImage = global::CarsCreator.Properties.Resources.tvGrey;
                this.TVP.Text = "no";
                this.TVP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.TVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private void xeonPanel_Click_1(object sender, EventArgs e)
        {
            this.carset.xeon = !this.carset.xeon;
            if (carset.xeon)
            {
                this.XenP.Text = "+ 61$";
                this.XenP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.XenP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.xeonPanel.BackgroundImage = global::CarsCreator.Properties.Resources.xC;
            }
            else
            {
                this.xeonPanel.BackgroundImage = global::CarsCreator.Properties.Resources.xG;
                this.XenP.Text = "no";
                this.XenP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.XenP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
                        this.diskLabel.ImageIndex = carset.diskIndex;
                        this.diskLabel.Text = "";
                        this.promptToDisk.Visible = false;
                        con.Open();
                        String cmndStr = "Select price from DiskPrice where idDisk = " + askd.diskIndex;
                        SqlCommand cmnd = new SqlCommand(cmndStr, con);
                        using (SqlDataReader reader = cmnd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.carset.diskPrice = (int)reader.GetValue(0);
                            }
                        }
                        con.Close();
                        this.DisksPriceLabel.Text = "+" + this.carset.diskPrice + "$";
                        this.DisksPriceLabel.Visible = true;
                        this.DisksPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                    }
                    else
                    {
                        MessageBox.Show("You have to chose model of disk");
                    }
                }
            }
        }

        private void engineBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            
            int carsID = -1;
            //String cmndStr = "Select engineValue from CarsGeneration where carsID = " + carsID;
            String cmndStr = "Select id from Cars where fName = \'" + carset.model + "\'";
            SqlCommand cmnd = new SqlCommand(cmndStr, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                if (reader.Read())
                {
                    carsID = (int)reader.GetValue(0);
                }
            }
            cmndStr = "Select price from CarsGeneration where carsID = " + carsID + "and engineValue = " + this.engineBox.Text;
            cmnd = new SqlCommand(cmndStr, con);
            using (SqlDataReader reader = cmnd.ExecuteReader())
            {
                if (reader.Read())
                {
                    this.priceEngineLabel.Text = "+ " + (int)reader.GetValue(0) + "$";
                    this.carset.priceWithEngine = (int)reader.GetValue(0);
                }
            }
            con.Close();
            this.priceEngineLabel.Visible = true;
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
        public int engineValue = 0;
        public int priceWithEngine = 0;
        public int diskIndex = 0;
        public int diskPrice = 0;
    } 
}
