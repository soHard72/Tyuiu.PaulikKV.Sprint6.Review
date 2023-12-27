
namespace Tyuiu.PaulikKV.Sprint6.TaskReview.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonClose_PKV = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_PKV = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_PKV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose_PKV
            // 
            this.buttonClose_PKV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose_PKV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClose_PKV.Location = new System.Drawing.Point(419, 220);
            this.buttonClose_PKV.Name = "buttonClose_PKV";
            this.buttonClose_PKV.Size = new System.Drawing.Size(85, 27);
            this.buttonClose_PKV.TabIndex = 0;
            this.buttonClose_PKV.Text = "OK";
            this.buttonClose_PKV.UseVisualStyleBackColor = true;
            this.buttonClose_PKV.Click += new System.EventHandler(this.buttonClose_PKV_Click);
            // 
            // pictureBoxAvatar_PKV
            // 
            this.pictureBoxAvatar_PKV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PKV.Image")));
            this.pictureBoxAvatar_PKV.Location = new System.Drawing.Point(1, 3);
            this.pictureBoxAvatar_PKV.Name = "pictureBoxAvatar_PKV";
            this.pictureBoxAvatar_PKV.Size = new System.Drawing.Size(220, 251);
            this.pictureBoxAvatar_PKV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PKV.TabIndex = 1;
            this.pictureBoxAvatar_PKV.TabStop = false;
            // 
            // textBoxInfo_PKV
            // 
            this.textBoxInfo_PKV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_PKV.Location = new System.Drawing.Point(227, 3);
            this.textBoxInfo_PKV.Multiline = true;
            this.textBoxInfo_PKV.Name = "textBoxInfo_PKV";
            this.textBoxInfo_PKV.ReadOnly = true;
            this.textBoxInfo_PKV.Size = new System.Drawing.Size(277, 211);
            this.textBoxInfo_PKV.TabIndex = 2;
            this.textBoxInfo_PKV.Text = resources.GetString("textBoxInfo_PKV.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 259);
            this.Controls.Add(this.textBoxInfo_PKV);
            this.Controls.Add(this.pictureBoxAvatar_PKV);
            this.Controls.Add(this.buttonClose_PKV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике     ";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose_PKV;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_PKV;
        private System.Windows.Forms.TextBox textBoxInfo_PKV;
    }
}