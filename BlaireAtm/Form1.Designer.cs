﻿namespace BlaireAtm
{
    partial class Form1
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
            this.NewAtmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewAtmBtn
            // 
            this.NewAtmBtn.Location = new System.Drawing.Point(12, 12);
            this.NewAtmBtn.Name = "NewAtmBtn";
            this.NewAtmBtn.Size = new System.Drawing.Size(96, 37);
            this.NewAtmBtn.TabIndex = 0;
            this.NewAtmBtn.Text = "New ATM";
            this.NewAtmBtn.UseVisualStyleBackColor = true;
            this.NewAtmBtn.Click += new System.EventHandler(this.NewAtmBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 58);
            this.Controls.Add(this.NewAtmBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewAtmBtn;
    }
}
