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

namespace EventControl
{
    public partial class MyEventControl: UserControl
    {
        public MyEventControl(MyEvent myEvent)
        {
            InitializeComponent();
            textBoxName.Text = myEvent.Name ?? "";
            textBoxDescription.Text = myEvent.Description ?? "";
            labelDate.Text = $"Date: {myEvent.EventDate}";
            if (myEvent.Duration == DateTimeOffset.MinValue)
                labelDuration.Visible = false;
            else
                labelDuration.Text = $"Duration: {myEvent.Duration}";
            labelPriority.Text = $"Priority: {myEvent.Priority}";
            Tag = myEvent.EventDate;
        }
    }
}
