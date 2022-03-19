using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using clockcontrolpractice;


namespace peedymerlinpracticeapp
{
    public partial class Form1 : Form
    {
        DoubleAgentCtl.DaCtlCharacter speaker;

        public Form1()
        {
            InitializeComponent();
            string loc = @"D:\agent control\";
            agent.Characters.Load("Peedy", loc + "Peedy.acs");
            agent.Characters.Load("Merlin", loc + "Merlin.acs");
            // to make character default
            speaker = agent.Characters["Peedy"];
            loadmoods();
            speaker.Show(0);

            c.d += new del(c_d);
            c.startit();
        }
        public void loadmoods()
        {
            IEnumerator arr = agent.Characters[speaker.Name].Animations.GetEnumerator();
            mood.Items.Clear(); //to clear the items of combobox
            while(arr.MoveNext())
                mood.Items.Add(arr.Current);

                mood.SelectedIndex = 5;
        }

        private void ped_CheckedChanged(object sender, EventArgs e)
        {
            speaker.Hide(0);
            speaker = agent.Characters["Peedy"];
            loadmoods();
            speaker.Show(0);
        }

        private void mer_CheckedChanged(object sender, EventArgs e)
        {
            speaker.Hide(0);
            speaker = agent.Characters["Merlin"];
            loadmoods();
            speaker.Show(0);
        }

        private void mood_SelectedIndexChanged(object sender, EventArgs e)
        {
            speaker.StopAll("Play");
            speaker.Play(mood.Text);
            speaker.Play("RestPose");

        }

        private void speak_Click(object sender, EventArgs e)
        {
            //speaker.StopAll("Play");
            speaker.Play(mood.Text);
            speaker.Play("RestPose");
            speaker.Speak(speechtext.Text + " ");
        }
        public void c_d(object sender, TimeEventArgs t)
        {
            for(int i = 0; i<5; i++)
            {
                speaker.Speak(t.msg);
            }
        }
    }
}
