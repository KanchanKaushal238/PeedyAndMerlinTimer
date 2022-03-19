using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockcontrolpractice
{
    public class TimeEventArgs : EventArgs
    {
        public string msg;
        public TimeEventArgs(string msg)
        {
            this.msg = msg;
        }
    }
}
