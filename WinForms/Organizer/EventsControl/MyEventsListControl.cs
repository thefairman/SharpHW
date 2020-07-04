using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organizer;
using EventControl;

namespace EventsControl
{
    public partial class MyEventsListControl : UserControl
    {
        public MyEventsListControl()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        public void AddElements(IEnumerable<MyEvent> myEvents)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = myEvents.Count();
            int row = 0;
            foreach (var item in myEvents)
            {
                tableLayoutPanel1.Controls.Add(new MyEventControl(item), 0, row++);
            }
            foreach (var item in tableLayoutPanel1.Controls)
            {
                ((MyEventControl)item).Dock = DockStyle.Fill;
            }
        }

        public void ClearElements()
        {
            tableLayoutPanel1.Controls.Clear();
        }
    }
}
