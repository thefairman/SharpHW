using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class MainForm : Form
    {
        static public EventManagerFacade EventsManager { get; private set; } = new EventManagerFacade();
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            EventsViewForm dlg = new EventsViewForm();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //EventsManager.AddEvent(new MyEvent
            //{
            //    Name = "Выполнить Д/З по WinForms",
            //    Description = "Домашнее задание КА ШАГ",
            //    Duration = new TimeSpan(0, 1, 0),
            //    EventDate = DateTime.Now.AddSeconds(5)
            //});

            //EventsManager.AddEvent(new MyEvent
            //{
            //    Name = "Выполнить Д/З по Design Patterns",
            //    Description = "Домашнее задание КА ШАГ",
            //    EventDate = new DateTime(2020, 08, 10)
            //});

            //EventsManager.AddEvent(new MyEvent
            //{
            //    Name = "Пойти погулять",
            //    Description = "После выполнения домашнего задания КА ШАГ",
            //    EventDate = new DateTime(2020, 08, 11)
            //});

            myEventsListControl1.AddElements(EventsManager.GetNearestEvents());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var doneList = myEventsListControl1.UpdateRemainTime();
            if (doneList?.Count > 0)
            {
                foreach (var item in doneList)
                {
                    (new EventAlertForm(item.Value)).Show(this);
                }
                myEventsListControl1.AddElements(EventsManager.GetNearestEvents(doneList.Last().Key));
            }
            timer1.Start();
        }

        private void buttonEventsManager_Click(object sender, EventArgs e)
        {
            EventsViewForm dlg = new EventsViewForm();
            dlg.ShowDialog(this);
        }
    }
}
