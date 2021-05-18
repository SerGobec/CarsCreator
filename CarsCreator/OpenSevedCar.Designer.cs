
namespace CarsCreator
{
    partial class OpenSevedCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenSevedCar));
            this.savedBox = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savedBox
            // 
            this.savedBox.AllowDrop = true;
            this.savedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.savedBox.FormattingEnabled = true;
            this.savedBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.savedBox.IntegralHeight = false;
            this.savedBox.ItemHeight = 16;
            this.savedBox.Location = new System.Drawing.Point(34, 12);
            this.savedBox.MaxDropDownItems = 5;
            this.savedBox.Name = "savedBox";
            this.savedBox.Size = new System.Drawing.Size(227, 24);
            this.savedBox.TabIndex = 0;
            this.savedBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(89, 130);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(118, 46);
            this.OK.TabIndex = 1;
            this.OK.Text = "Open";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // OpenSevedCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(295, 188);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.savedBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenSevedCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenSevedCar";
            this.Load += new System.EventHandler(this.OpenSevedCar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox savedBox;
        private System.Windows.Forms.Button OK;
    }
}