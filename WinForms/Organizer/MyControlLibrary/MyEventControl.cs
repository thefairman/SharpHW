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
        public MyEvent myEvent { get; protected set; }
        public MyEventControl(MyEvent myEvent)
        {
            InitializeComponent();

            this.myEvent = myEvent;
            textBoxName.Text = myEvent?.Name ?? "";
            textBoxDescription.Text = myEvent?.Description ?? "";
            labelDate.Text = $"Дата: {myEvent.EventDate}";
            if (myEvent.Duration == TimeSpan.MinValue)
                labelDuration.Visible = false;
            else
                labelDuration.Text = $"Продолжительность: {myEvent.Duration}";
            labelPriority.Text = $"Приоритет: {myEvent.Priority}";
            Tag = myEvent.EventDate;
            UpdateRemain();
        }

        public bool UpdateRemain()
        {
            var ellapsed = myEvent.EventDate - DateTime.Now;
            labelRemain.Text = $"До события осталось: {String.Format("{0:%d} суток/сутки {0:%h}:{0:%m}:{0:%s}", (ellapsed))}";
            return ellapsed.Milliseconds > 0;
        }
    }
}
