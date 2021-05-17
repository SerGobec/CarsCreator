
using System;
using System.Windows.Forms;

namespace CarsCreator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.xeonPanel = new System.Windows.Forms.Panel();
            this.tvPanel = new System.Windows.Forms.Panel();
            this.sonarPanel = new System.Windows.Forms.Panel();
            this.sitPanel = new System.Windows.Forms.Panel();
            this.sabPanel = new System.Windows.Forms.Panel();
            this.signalingPanel = new System.Windows.Forms.Panel();
            this.carterPanel = new System.Windows.Forms.Panel();
            this.carPanel = new System.Windows.Forms.Panel();
            this.diskLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.infoPanel = new System.Windows.Forms.Panel();
            this.XenP = new System.Windows.Forms.Label();
            this.TVP = new System.Windows.Forms.Label();
            this.ParkP = new System.Windows.Forms.Label();
            this.HeatingP = new System.Windows.Forms.Label();
            this.AudioP = new System.Windows.Forms.Label();
            this.SignalP = new System.Windows.Forms.Label();
            this.carterP = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DisksPriceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceEngineLabel = new System.Windows.Forms.Label();
            this.engineBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelLabelInfo = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.promptToDisk = new System.Windows.Forms.Label();
            this.setDeafaultDisksButton = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.ExitButton);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1006, 73);
            this.header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "CarsCreator";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(944, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 46);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // xeonPanel
            // 
            this.xeonPanel.BackgroundImage = global::CarsCreator.Properties.Resources.xG;
            this.xeonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xeonPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xeonPanel.Location = new System.Drawing.Point(525, 579);
            this.xeonPanel.Name = "xeonPanel";
            this.xeonPanel.Size = new System.Drawing.Size(115, 110);
            this.xeonPanel.TabIndex = 8;
            this.xeonPanel.Click += new System.EventHandler(this.xeonPanel_Click_1);
            // 
            // tvPanel
            // 
            this.tvPanel.BackgroundImage = global::CarsCreator.Properties.Resources.tvGrey;
            this.tvPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tvPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvPanel.Location = new System.Drawing.Point(705, 579);
            this.tvPanel.Name = "tvPanel";
            this.tvPanel.Size = new System.Drawing.Size(133, 110);
            this.tvPanel.TabIndex = 7;
            this.tvPanel.Click += new System.EventHandler(this.tvPanel_Click);
            // 
            // sonarPanel
            // 
            this.sonarPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sonarG;
            this.sonarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sonarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sonarPanel.Location = new System.Drawing.Point(873, 514);
            this.sonarPanel.Name = "sonarPanel";
            this.sonarPanel.Size = new System.Drawing.Size(121, 107);
            this.sonarPanel.TabIndex = 6;
            this.sonarPanel.Click += new System.EventHandler(this.sonarPanel_Click);
            // 
            // sitPanel
            // 
            this.sitPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sitGrey;
            this.sitPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sitPanel.Location = new System.Drawing.Point(892, 116);
            this.sitPanel.Name = "sitPanel";
            this.sitPanel.Size = new System.Drawing.Size(102, 107);
            this.sitPanel.TabIndex = 5;
            this.sitPanel.Click += new System.EventHandler(this.sitPanel_Click);
            // 
            // sabPanel
            // 
            this.sabPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sabGrey;
            this.sabPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sabPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sabPanel.Location = new System.Drawing.Point(705, 93);
            this.sabPanel.Name = "sabPanel";
            this.sabPanel.Size = new System.Drawing.Size(133, 107);
            this.sabPanel.TabIndex = 4;
            this.sabPanel.Click += new System.EventHandler(this.sabPanel_Click_1);
            // 
            // signalingPanel
            // 
            this.signalingPanel.BackgroundImage = global::CarsCreator.Properties.Resources.sG;
            this.signalingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signalingPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signalingPanel.Location = new System.Drawing.Point(525, 93);
            this.signalingPanel.Name = "signalingPanel";
            this.signalingPanel.Size = new System.Drawing.Size(115, 107);
            this.signalingPanel.TabIndex = 3;
            this.signalingPanel.Click += new System.EventHandler(this.signaling_Click);
            // 
            // carterPanel
            // 
            this.carterPanel.BackgroundImage = global::CarsCreator.Properties.Resources.carG;
            this.carterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.carterPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carterPanel.Location = new System.Drawing.Point(355, 116);
            this.carterPanel.Name = "carterPanel";
            this.carterPanel.Size = new System.Drawing.Size(110, 107);
            this.carterPanel.TabIndex = 2;
            this.carterPanel.Click += new System.EventHandler(this.panel1_Click);
            // 
            // carPanel
            // 
            this.carPanel.BackgroundImage = global::CarsCreator.Properties.Resources.car_default;
            this.carPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.carPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carPanel.Location = new System.Drawing.Point(380, 251);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(547, 247);
            this.carPanel.TabIndex = 1;
            this.carPanel.Click += new System.EventHandler(this.carPanel_Click);
            this.carPanel.MouseEnter += new System.EventHandler(this.car_MouseEnter);
            this.carPanel.MouseLeave += new System.EventHandler(this.car_MouseLeave);
            // 
            // diskLabel
            // 
            this.diskLabel.BackColor = System.Drawing.SystemColors.Control;
            this.diskLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diskLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diskLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.diskLabel.ImageIndex = 14;
            this.diskLabel.ImageList = this.imageList1;
            this.diskLabel.Location = new System.Drawing.Point(317, 514);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(148, 140);
            this.diskLabel.TabIndex = 9;
            this.diskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diskLabel.Click += new System.EventHandler(this.diskLabel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            this.imageList1.Images.SetKeyName(10, "10.png");
            this.imageList1.Images.SetKeyName(11, "11.png");
            this.imageList1.Images.SetKeyName(12, "12.png");
            this.imageList1.Images.SetKeyName(13, "13.png");
            this.imageList1.Images.SetKeyName(14, "default.png");
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.infoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.XenP);
            this.infoPanel.Controls.Add(this.TVP);
            this.infoPanel.Controls.Add(this.ParkP);
            this.infoPanel.Controls.Add(this.HeatingP);
            this.infoPanel.Controls.Add(this.AudioP);
            this.infoPanel.Controls.Add(this.SignalP);
            this.infoPanel.Controls.Add(this.carterP);
            this.infoPanel.Controls.Add(this.label11);
            this.infoPanel.Controls.Add(this.label10);
            this.infoPanel.Controls.Add(this.label9);
            this.infoPanel.Controls.Add(this.label8);
            this.infoPanel.Controls.Add(this.label7);
            this.infoPanel.Controls.Add(this.label6);
            this.infoPanel.Controls.Add(this.label5);
            this.infoPanel.Controls.Add(this.DisksPriceLabel);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.priceEngineLabel);
            this.infoPanel.Controls.Add(this.engineBox);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.ModelLabelInfo);
            this.infoPanel.Controls.Add(this.carModelLabel);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Location = new System.Drawing.Point(3, 79);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(254, 630);
            this.infoPanel.TabIndex = 10;
            // 
            // XenP
            // 
            this.XenP.AutoSize = true;
            this.XenP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XenP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XenP.Location = new System.Drawing.Point(86, 422);
            this.XenP.Name = "XenP";
            this.XenP.Size = new System.Drawing.Size(30, 20);
            this.XenP.TabIndex = 21;
            this.XenP.Text = "no";
            // 
            // TVP
            // 
            this.TVP.AutoSize = true;
            this.TVP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TVP.Location = new System.Drawing.Point(108, 387);
            this.TVP.Name = "TVP";
            this.TVP.Size = new System.Drawing.Size(30, 20);
            this.TVP.TabIndex = 20;
            this.TVP.Text = "no";
            // 
            // ParkP
            // 
            this.ParkP.AutoSize = true;
            this.ParkP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParkP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ParkP.Location = new System.Drawing.Point(116, 352);
            this.ParkP.Name = "ParkP";
            this.ParkP.Size = new System.Drawing.Size(30, 20);
            this.ParkP.TabIndex = 19;
            this.ParkP.Text = "no";
            // 
            // HeatingP
            // 
            this.HeatingP.AutoSize = true;
            this.HeatingP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeatingP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeatingP.Location = new System.Drawing.Point(170, 313);
            this.HeatingP.Name = "HeatingP";
            this.HeatingP.Size = new System.Drawing.Size(30, 20);
            this.HeatingP.TabIndex = 18;
            this.HeatingP.Text = "no";
            // 
            // AudioP
            // 
            this.AudioP.AutoSize = true;
            this.AudioP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AudioP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AudioP.Location = new System.Drawing.Point(78, 276);
            this.AudioP.Name = "AudioP";
            this.AudioP.Size = new System.Drawing.Size(30, 20);
            this.AudioP.TabIndex = 17;
            this.AudioP.Text = "no";
            // 
            // SignalP
            // 
            this.SignalP.AutoSize = true;
            this.SignalP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignalP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignalP.Location = new System.Drawing.Point(111, 242);
            this.SignalP.Name = "SignalP";
            this.SignalP.Size = new System.Drawing.Size(30, 20);
            this.SignalP.TabIndex = 16;
            this.SignalP.Text = "no";
            // 
            // carterP
            // 
            this.carterP.AutoSize = true;
            this.carterP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carterP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.carterP.Location = new System.Drawing.Point(82, 204);
            this.carterP.Name = "carterP";
            this.carterP.Size = new System.Drawing.Size(30, 20);
            this.carterP.TabIndex = 15;
            this.carterP.Text = "no";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label11.Location = new System.Drawing.Point(9, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Xenon:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label10.Location = new System.Drawing.Point(9, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "TV in car:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label9.Location = new System.Drawing.Point(7, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Parktronic:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label8.Location = new System.Drawing.Point(7, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Heating of seats:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label7.Location = new System.Drawing.Point(6, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Audio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(7, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Signaling:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carter:";
            // 
            // DisksPriceLabel
            // 
            this.DisksPriceLabel.AutoSize = true;
            this.DisksPriceLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisksPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DisksPriceLabel.Location = new System.Drawing.Point(75, 171);
            this.DisksPriceLabel.Name = "DisksPriceLabel";
            this.DisksPriceLabel.Size = new System.Drawing.Size(76, 20);
            this.DisksPriceLabel.TabIndex = 7;
            this.DisksPriceLabel.Text = "default";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Disks:";
            // 
            // priceEngineLabel
            // 
            this.priceEngineLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceEngineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.priceEngineLabel.Location = new System.Drawing.Point(114, 130);
            this.priceEngineLabel.Name = "priceEngineLabel";
            this.priceEngineLabel.Size = new System.Drawing.Size(113, 26);
            this.priceEngineLabel.TabIndex = 5;
            this.priceEngineLabel.Text = "label4";
            this.priceEngineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.priceEngineLabel.Visible = false;
            // 
            // engineBox
            // 
            this.engineBox.BackColor = System.Drawing.Color.BurlyWood;
            this.engineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineBox.FormattingEnabled = true;
            this.engineBox.Location = new System.Drawing.Point(10, 130);
            this.engineBox.Name = "engineBox";
            this.engineBox.Size = new System.Drawing.Size(98, 26);
            this.engineBox.TabIndex = 4;
            this.engineBox.Visible = false;
            this.engineBox.SelectionChangeCommitted += new System.EventHandler(this.engineBox_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(2, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Engine model(h.p.):";
            this.label3.Visible = false;
            // 
            // ModelLabelInfo
            // 
            this.ModelLabelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModelLabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ModelLabelInfo.Location = new System.Drawing.Point(10, 65);
            this.ModelLabelInfo.Name = "ModelLabelInfo";
            this.ModelLabelInfo.Size = new System.Drawing.Size(232, 42);
            this.ModelLabelInfo.TabIndex = 2;
            this.ModelLabelInfo.Text = "Isn`t chosen(click on car for chose model)";
            this.ModelLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carModelLabel
            // 
            this.carModelLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.carModelLabel.Location = new System.Drawing.Point(3, 40);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(105, 25);
            this.carModelLabel.TabIndex = 1;
            this.carModelLabel.Text = "Car model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(36, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Info panel";
            // 
            // promptToDisk
            // 
            this.promptToDisk.BackColor = System.Drawing.SystemColors.Control;
            this.promptToDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.promptToDisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(65)))));
            this.promptToDisk.Location = new System.Drawing.Point(283, 664);
            this.promptToDisk.Name = "promptToDisk";
            this.promptToDisk.Size = new System.Drawing.Size(131, 65);
            this.promptToDisk.TabIndex = 11;
            this.promptToDisk.Text = "Click for ↑         chose disks";
            // 
            // setDeafaultDisksButton
            // 
            this.setDeafaultDisksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.setDeafaultDisksButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.setDeafaultDisksButton.Location = new System.Drawing.Point(322, 664);
            this.setDeafaultDisksButton.Name = "setDeafaultDisksButton";
            this.setDeafaultDisksButton.Size = new System.Drawing.Size(127, 32);
            this.setDeafaultDisksButton.TabIndex = 12;
            this.setDeafaultDisksButton.Text = "SET DEFAULT";
            this.setDeafaultDisksButton.UseVisualStyleBackColor = false;
            this.setDeafaultDisksButton.Visible = false;
            this.setDeafaultDisksButton.Click += new System.EventHandler(this.setDeafaultDisksButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.setDeafaultDisksButton);
            this.Controls.Add(this.promptToDisk);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.diskLabel);
            this.Controls.Add(this.xeonPanel);
            this.Controls.Add(this.tvPanel);
            this.Controls.Add(this.sonarPanel);
            this.Controls.Add(this.sitPanel);
            this.Controls.Add(this.sabPanel);
            this.Controls.Add(this.signalingPanel);
            this.Controls.Add(this.carterPanel);
            this.Controls.Add(this.carPanel);
            this.Controls.Add(this.header);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel carterPanel;
        private System.Windows.Forms.Label label1;
        private Panel signalingPanel;
        private Panel sabPanel;
        private Panel sitPanel;
        private Panel sonarPanel;
        private Panel tvPanel;
        private Panel xeonPanel;
        private Label diskLabel;
        private ImageList imageList1;
        private Panel infoPanel;
        private Label promptToDisk;
        private Label label2;
        private Label ModelLabelInfo;
        private Label carModelLabel;
        private Label label3;
        private ComboBox engineBox;
        private Label priceEngineLabel;
        private Label label4;
        private Label DisksPriceLabel;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label XenP;
        private Label TVP;
        private Label ParkP;
        private Label HeatingP;
        private Label AudioP;
        private Label SignalP;
        private Label carterP;
        private Button setDeafaultDisksButton;
    }
}

