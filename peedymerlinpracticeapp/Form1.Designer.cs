namespace peedymerlinpracticeapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.speechtext = new System.Windows.Forms.TextBox();
            this.speak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mer = new System.Windows.Forms.RadioButton();
            this.ped = new System.Windows.Forms.RadioButton();
            this.mood = new System.Windows.Forms.ComboBox();
            this.agent = new AxDoubleAgentCtl.AxDaControl();
            this.c = new clockcontrolpractice.timer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agent)).BeginInit();
            this.SuspendLayout();
            // 
            // speechtext
            // 
            this.speechtext.Location = new System.Drawing.Point(21, 32);
            this.speechtext.Name = "speechtext";
            this.speechtext.Size = new System.Drawing.Size(315, 20);
            this.speechtext.TabIndex = 0;
            // 
            // speak
            // 
            this.speak.Location = new System.Drawing.Point(389, 32);
            this.speak.Name = "speak";
            this.speak.Size = new System.Drawing.Size(75, 23);
            this.speak.TabIndex = 1;
            this.speak.Text = "Speak";
            this.speak.UseVisualStyleBackColor = true;
            this.speak.Click += new System.EventHandler(this.speak_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mer);
            this.groupBox1.Controls.Add(this.ped);
            this.groupBox1.Controls.Add(this.mood);
            this.groupBox1.Location = new System.Drawing.Point(21, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characters";
            // 
            // mer
            // 
            this.mer.AutoSize = true;
            this.mer.Location = new System.Drawing.Point(33, 83);
            this.mer.Name = "mer";
            this.mer.Size = new System.Drawing.Size(53, 17);
            this.mer.TabIndex = 2;
            this.mer.Text = "Merlin";
            this.mer.UseVisualStyleBackColor = true;
            this.mer.CheckedChanged += new System.EventHandler(this.mer_CheckedChanged);
            // 
            // ped
            // 
            this.ped.AutoSize = true;
            this.ped.Checked = true;
            this.ped.Location = new System.Drawing.Point(33, 39);
            this.ped.Name = "ped";
            this.ped.Size = new System.Drawing.Size(55, 17);
            this.ped.TabIndex = 1;
            this.ped.TabStop = true;
            this.ped.Text = "Peedy";
            this.ped.UseVisualStyleBackColor = true;
            this.ped.CheckedChanged += new System.EventHandler(this.ped_CheckedChanged);
            // 
            // mood
            // 
            this.mood.FormattingEnabled = true;
            this.mood.Location = new System.Drawing.Point(181, 44);
            this.mood.Name = "mood";
            this.mood.Size = new System.Drawing.Size(121, 21);
            this.mood.TabIndex = 0;
            this.mood.Text = "Select Action";
            this.mood.SelectedIndexChanged += new System.EventHandler(this.mood_SelectedIndexChanged);
            // 
            // agent
            // 
            this.agent.Enabled = true;
            this.agent.Location = new System.Drawing.Point(389, 104);
            this.agent.Name = "agent";
            this.agent.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("agent.OcxState")));
            this.agent.Size = new System.Drawing.Size(87, 82);
            this.agent.TabIndex = 3;
            // 
            // c
            // 
            this.c.almessage = "Fart";
            this.c.altime = "19:59";
            this.c.Location = new System.Drawing.Point(21, 229);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(455, 52);
            this.c.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 298);
            this.Controls.Add(this.c);
            this.Controls.Add(this.agent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.speak);
            this.Controls.Add(this.speechtext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox speechtext;
        private System.Windows.Forms.Button speak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mer;
        private System.Windows.Forms.RadioButton ped;
        private System.Windows.Forms.ComboBox mood;
        private AxDoubleAgentCtl.AxDaControl agent;
        private clockcontrolpractice.timer c;
    }
}

