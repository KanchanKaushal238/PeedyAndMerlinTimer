﻿namespace clockcontrolpractice
{
    partial class timer
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.mytimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer";
            // 
            // time
            // 
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time.Location = new System.Drawing.Point(110, 19);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(280, 13);
            this.time.TabIndex = 1;
            // 
            // mytimer
            // 
            this.mytimer.Interval = 1000;
            this.mytimer.Tick += new System.EventHandler(this.mytimer_Tick);
            // 
            // timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.Name = "timer";
            this.Size = new System.Drawing.Size(429, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer mytimer;
    }
}
