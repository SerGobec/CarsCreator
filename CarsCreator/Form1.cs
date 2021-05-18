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
using System.IO;
using System.Reflection;
using CarsCreator.Models;
using CarsCreator.Services;

namespace CarsCreator
{
    
    public partial class Form1 : Form
    {
        StreamService streamservise;
        SqlService sqlservice;
        CarSet carset;
        public Form1()
        {
            // init services
            streamservise = new StreamService();
            sqlservice = new SqlService();
            // init models
            carset = new CarSet();
            //----------------------------------
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
            RepaintElements();
            this.ResultLabel.Text = ReCountCost_ForLabel();
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
            this.carPanel.Width -= 10;
        }

        private void signaling_Click(object sender, EventArgs e)
        {
            this.carset.signal = !this.carset.signal;
            RepaintElements();
            
            this.ResultLabel.Text = ReCountCost_ForLabel();
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
                        // Fill Engine Values Box
                        int carsID = sqlservice.GetCarIDbyModel(carset.model);
                        List<string> engineValues = sqlservice.GetEngiveValueByID(carsID);
                        for(int i = 0;i < engineValues.Count; i++)
                        {
                            engineBox.Items.Add(engineValues[i]);
                        }

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
            this.ResultLabel.Text = ReCountCost_ForLabel();
        }

        private void sabPanel_Click_1(object sender, EventArgs e)
        {
            this.carset.sab = !this.carset.sab;
            RepaintElements();
            this.ResultLabel.Text = ReCountCost_ForLabel();
        }

        private void sitPanel_Click(object sender, EventArgs e)
        {
            this.carset.sit = !this.carset.sit;
            RepaintElements();
            this.ResultLabel.Text = ReCountCost_ForLabel();
        }

        private void sonarPanel_Click(object sender, EventArgs e)
        {
            this.carset.sonar = !this.carset.sonar;
            RepaintElements();
            this.ResultLabel.Text = ReCountCost_ForLabel();
        }

        private void tvPanel_Click(object sender, EventArgs e)
        {
            this.carset.tv = !this.carset.tv;
            RepaintElements();
            this.ResultLabel.Text = ReCountCost_ForLabel();
        }

        private void xeonPanel_Click_1(object sender, EventArgs e)
        {
            this.carset.xeon = !this.carset.xeon;
            RepaintElements();
            this.ResultLabel.Text = ReCountCost_ForLabel();
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
                        //
                        // Set Price for disks
                        //
                        this.carset.diskPrice = sqlservice.GetPriceOfDiskbyIndex(askd.diskIndex);

                        this.DisksPriceLabel.Text = "+" + this.carset.diskPrice + "$";
                        this.DisksPriceLabel.Visible = true;
                        this.DisksPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                        this.setDeafaultDisksButton.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You have to chose model of disk");
                    }
                }
            }
            this.ResultLabel.Text = ReCountCost_ForLabel();
        }

        private void engineBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int carsID = sqlservice.GetCarIDbyModel(carset.model);
            this.carset.engineValue = Int32.Parse(engineBox.Text);
            this.carset.priceWithEngine = sqlservice.GetPricebyIDandEngine(carsID, Int32.Parse(engineBox.Text));
            this.priceEngineLabel.Text = "+ " + carset.priceWithEngine + "$";
            this.priceEngineLabel.Visible = true;
            this.ResultLabel.Text = ReCountCost_ForLabel();
        }

        private void setDeafaultDisksButton_Click(object sender, EventArgs e)
        {
            this.setDeafaultDisksButton.Visible = false;
            this.carset.diskPrice = 0;
            this.diskLabel.ImageIndex = 14;
            this.DisksPriceLabel.Text = "default";
            this.DisksPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResultLabel.Text = ReCountCost_ForLabel();
        }

        private string ReCountCost_ForLabel()
        {
            this.ResultLabel.Visible = true;
            if (carset.priceWithEngine == 0)
            {
                return "please, chose model of engine";
            }
            int sum = RecountService.recount(this.carset);
            return sum+"$";
        }

        private void SaveModel(object sender, EventArgs e)
        {
            if(carset.model == "")
            {
                MessageBox.Show("You have to choose model at least.");
                return;
            }
            String model = this.carset.model + ";"+ this.carset.engineValue + ";" +carset.diskIndex+";"+ carset.carter + ";" +
                carset.signal + ";" + carset.sab + ";" + carset.sit + ";" +
                carset.sonar + ";" + carset.tv + ";" + carset.xeon;

            string[] savedModels = streamservise.ReadModels().Split('\n');
            for (int i = 0; i < savedModels.Length; i++)
            {
                Console.WriteLine(savedModels[i]);
                if (savedModels[i] == model+"\r")
                {
                    MessageBox.Show("Model is already saved!");
                    return;
                }
            }
            this.streamservise.WriteModel(model);
            MessageBox.Show("Model successfully saved!");
        }

        private void OpenModel(object sender, EventArgs e)
        {
            int chosenIndex = -1;
            using (OpenSevedCar askf = new OpenSevedCar())
            {
                if (askf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chosenIndex = askf.GetBoxIndex();
                    RepaintElements();
                }
            }
            if(chosenIndex != -1)
            {
                this.carset = this.streamservise.GetSavedCarByIndex(chosenIndex);
                RepaintElements();
            }
           /* try
            {
                string actual = this.streamservise.ReadModels();
                string[] mas = actual.Split('\n');
                for(int i = 0;i < mas.Length; i++)
                {
                    if(mas[i] != "") MessageBox.Show(mas[i]);
                }
            }
            catch
            {
                MessageBox.Show("There isn`t saved models!");
            } */
        }

        private void RepaintElements()
        {
            //--------< Carter >---------
            if (carset.carter)
            {
                this.carterP.Text = "+ 115$";
                this.carterP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.carterP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.carterPanel.BackgroundImage = global::CarsCreator.Properties.Resources.carC;
            }
            else
            {
                this.carterPanel.BackgroundImage = global::CarsCreator.Properties.Resources.carG;
                this.carterP.Text = "no";
                this.carterP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.carterP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
            //---------< Signalisation >---------
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
            //------< Xeon >----------
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
            //--------< TV >-----------
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
            //---------< Sonar >--------
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
            //---------< Sit heater >--------
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
            //---------< SAB >----------
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
            //
            // ------< Disks >-----
            if (carset.diskIndex != 14)
            {
                this.diskLabel.ImageIndex = carset.diskIndex;
                this.diskLabel.Text = "";
                this.promptToDisk.Visible = false;
                this.carset.diskPrice = sqlservice.GetPriceOfDiskbyIndex(carset.diskIndex);
                this.DisksPriceLabel.Text = "+" + this.carset.diskPrice + "$";
                this.DisksPriceLabel.Visible = true;
                this.DisksPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
                this.setDeafaultDisksButton.Visible = true;
            }
            //---------< Car
            if(carset.model != "")
            {
                String path = @"..\\carsModel\" + this.carset.model + ".png";
                try
                {
                    Bitmap bmp = new Bitmap(path);
                    carPanel.BackgroundImage = bmp;
                }
                catch
                {
                    carPanel.BackgroundImage = Properties.Resources.car_default;
                }
                this.ModelLabelInfo.Text = this.carset.model;
                this.ModelLabelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
                this.engineBox.Items.Clear();
                //----------< Engine Value
                int carsID = sqlservice.GetCarIDbyModel(carset.model);
                this.carset.priceWithEngine = sqlservice.GetPricebyIDandEngine(carsID, carset.engineValue);
                List<string> engineValues = sqlservice.GetEngiveValueByID(carsID);
                for (int i = 0; i < engineValues.Count; i++)
                {
                    engineBox.Items.Add(engineValues[i]);
                }
                engineBox.Text = carset.engineValue + "";
                this.engineBox.Visible = true;
                this.label3.Visible = true;
                this.priceEngineLabel.Visible = true;
                this.priceEngineLabel.Text = "+ " + this.carset.priceWithEngine + "$";
                this.ResultLabel.Text = ReCountCost_ForLabel();
            }
        }
    }

}
