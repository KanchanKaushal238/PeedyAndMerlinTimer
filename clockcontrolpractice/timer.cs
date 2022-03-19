using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clockcontrolpractice
{
    public delegate void del(object sender, TimeEventArgs t);
    public partial class timer: UserControl
    {
        public event del d;
        string settimer;
        string setmessage;
        
        public string altime
        {
            get
            {
                return settimer;
            }
            set
            {
                settimer = value;
            }
        }
        public string almessage
        {
            get
            {
                return setmessage;
            }
            set
            {
                setmessage = value;
            }
        }
        public timer()
        {
            InitializeComponent();
        }
        public void startit()
        {
            mytimer.Start();
        }
        public void stopit()
        {
            mytimer.Stop();
        }

        private void mytimer_Tick(object sender, EventArgs e)
        {
            DateTime dd = DateTime.Now;
            string str = dd.Hour + ":" + dd.Minute + ":" + dd.Second;
            time.Text = str;
            int i = str.LastIndexOf(":");
            str = str.Substring(0, i);
            if((str == altime) && (dd.Second == 0))
            {
                TimeEventArgs t = new TimeEventArgs(almessage);
                d(this, t); //this ->> reference to clock control, t-->> mediator
            }
        }
    }
}
