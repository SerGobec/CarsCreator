
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
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.label1.Font = new System.Drawing.Font("Jokerman", 24.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 47);
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
            this.diskLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diskLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diskLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.diskLabel.ImageIndex = 14;
            this.diskLabel.ImageList = this.imageList1;
            this.diskLabel.Location = new System.Drawing.Point(317, 514);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(148, 140);
            this.diskLabel.TabIndex = 9;
            this.diskLabel.Text = "CLICK FOR CHOSE DISK!";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
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
    }
}

