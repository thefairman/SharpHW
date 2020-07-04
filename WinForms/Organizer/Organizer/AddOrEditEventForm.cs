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
    public partial class AddOrEditEventForm : Form
    {
        MyEvent myEvent = null;
        public AddOrEditEventForm(MyEvent myEvent = null)
        {
            this.myEvent = myEvent;
            InitializeComponent();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            comboBoxPriorVal.Items.AddRange(Enum.GetNames(typeof(EventPriority)));
            comboBoxPriorVal.SelectedIndex = 1;

            //dateTimePickerDateEvent.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePickerDurationEvent.Value = new DateTime(2000,1,1,0,0,0);

            if (myEvent != null)
                FillPrevValues();
        }

        void FillPrevValues()
        {
            textBoxName.Text = myEvent.Name;
            textBoxDescription.Text = myEvent.Description;
            comboBoxPriorVal.SelectedItem = myEvent.Priority.ToString();
            dateTimePickerDateEvent.Value = myEvent.EventDate.Date;
            dateTimePickerTimeEvent.Value = DateTime.Now.Date + myEvent.EventDate.TimeOfDay;

            dateTimePickerDurationEvent.Value += myEvent.Duration;
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("В вашем событии должно быть хотя бы название!");
                return;
            }
            var val = dateTimePickerDateEvent.Value.Date + dateTimePickerTimeEvent.Value.TimeOfDay;
            var curEvent = new MyEvent
            {
                Description = textBoxDescription.Text,
                Duration = dateTimePickerDurationEvent.Value - dateTimePickerDurationEvent.Value.Date,
                EventDate = dateTimePickerDateEvent.Value.Date + dateTimePickerTimeEvent.Value.TimeOfDay,
                Guid = myEvent?.Guid ?? Guid.NewGuid(),
                Name = textBoxName.Text,
                Priority = (EventPriority)Enum.Parse(typeof(EventPriority), comboBoxPriorVal.SelectedItem.ToString())
            };
            if (myEvent == null)
                MainForm.EventsManager.AddEvent(curEvent);
            else
                MainForm.EventsManager.EditEvent(curEvent);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
