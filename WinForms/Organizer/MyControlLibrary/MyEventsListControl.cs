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
            tableLayoutPanel1.AutoScroll = true;
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            tableLayoutPanel1.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }

        public void AddElements(IEnumerable<IGrouping<DateTime, MyEvent>> myEvents)
        {
            tableLayoutPanel1.Controls.Clear();
            if (myEvents == null)
                return;
            int row = 0;
            foreach (var groups in myEvents)
            {
                tableLayoutPanel1.RowCount += groups.Count();
                foreach (var item in groups)
                {
                    tableLayoutPanel1.Controls.Add(new MyEventControl(item), 0, row++);
                }
            }

            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is MyEventControl) ((MyEventControl)item).Dock = DockStyle.Fill;
            }
        }

        public void ClearElements()
        {
            tableLayoutPanel1.Controls.Clear();
        }

        public SortedList<DateTime, MyEvent> UpdateRemainTime()
        {
            SortedList<DateTime, MyEvent> list = new SortedList<DateTime, MyEvent>();
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                var myEventControl = tableLayoutPanel1.Controls[i] as MyEventControl;
                if (myEventControl != null && !myEventControl.UpdateRemain())
                {
                    list.Add(myEventControl.myEvent.EventDate, myEventControl.myEvent);
                    tableLayoutPanel1.Controls.RemoveAt(i--);
                }
            }
            return list;
        }
    }
}
