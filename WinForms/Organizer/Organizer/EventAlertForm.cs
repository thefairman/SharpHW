using EventControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class EventAlertForm : Form
    {
        MyEvent myEvent;
        public EventAlertForm(MyEvent myEvent)
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Add(new MyEventControl(myEvent), 0, 0);
            tableLayoutPanel1.Controls[1].Dock = DockStyle.Fill;
            this.myEvent = myEvent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int curValPB;
            if (myEvent.Duration.TotalSeconds > 0)
            {
                var remain = -(myEvent.EventDate - DateTime.Now).TotalSeconds;
                curValPB = (int)(100.0 / myEvent.Duration.TotalSeconds * remain);
                if (curValPB > 100) curValPB = 100;
                else if (curValPB < 0) curValPB = 0;
            }
            else
            {
                progressBar1.Visible = false;
                timer1.Stop();
                return;
            }
            progressBar1.Value = curValPB;
            if (curValPB >= 100)
                timer1.Stop();
        }
    }
}
