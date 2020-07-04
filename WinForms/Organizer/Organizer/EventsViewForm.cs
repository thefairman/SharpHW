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
    public partial class EventsViewForm : Form
    {
        IEnumerable<MyEvent> resultQuery;
        public EventsViewForm()
        {
            InitializeComponent();

            listBoxEvents.DataSource = MainForm.EventsManager.MyEvents;
        }

        void SetDataToList(IEnumerable<MyEvent> data = null)
        {
            if (data == null)
            {
                listBoxEvents.DataSource = MainForm.EventsManager.MyEvents;
                return;
            }
            listBoxEvents.DataSource = new MyBindingList<MyEvent>(data.ToList());
            //SortOptionsChanged_CheckedChanged(null, null);
        }

        private void SortOptionsChanged_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDate.Checked)
            {
                resultQuery = MainForm.EventsManager.GetSortQuery(EventManagerFacade.OrderBy.Date, checkBoxDesc.Checked);
            }
            if (radioButtonPriority.Checked)
            {
                resultQuery = MainForm.EventsManager.GetSortQuery(EventManagerFacade.OrderBy.Priority, checkBoxDesc.Checked);
            }
            if (radioButtonName.Checked)
            {
                resultQuery = MainForm.EventsManager.GetSortQuery(EventManagerFacade.OrderBy.Name, checkBoxDesc.Checked);
            }
            SetDataToList(resultQuery);
        }

        private void EventsViewForm_Load(object sender, EventArgs e)
        {
            comboBoxSearchType.SelectedIndex = 0;
            comboBoxSeacrhPriorVal.Items.AddRange(Enum.GetNames(typeof(EventPriority)));
            comboBoxSeacrhPriorVal.SelectedIndex = 0;
            checkBoxSearchInRes.Text = "Искать в\r\nрезультате";
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSeacrhPriorVal.Visible = false;
            textBoxSearchVal.Visible = false;
            dateTimePicker1.Visible = false;
            switch (comboBoxSearchType.SelectedIndex)
            {
                case 1:
                    comboBoxSeacrhPriorVal.Visible = true;
                    break;
                case 2:
                    dateTimePicker1.Visible = true;
                    break;
                default:
                    textBoxSearchVal.Visible = true;
                    break;
            }
        }

        bool CheckSearchedText(out string text)
        {
            text = "";
            if (string.IsNullOrEmpty(textBoxSearchVal.Text))
                return false;
            text = textBoxSearchVal.Text;
            return true;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool unacceptebleData = false;
            string text;
            switch (comboBoxSearchType.SelectedIndex)
            {
                case 0:
                    if (CheckSearchedText(out text))
                        resultQuery = MainForm.EventsManager.GetSearchedList(checkBoxSearchInRes.Checked ? resultQuery : null, EventManagerFacade.SearchType.Name, text);
                    else
                        unacceptebleData = true;
                    break;
                case 1:
                    resultQuery = MainForm.EventsManager.GetSearchedList(checkBoxSearchInRes.Checked ? resultQuery : null, EventManagerFacade.SearchType.Priority, comboBoxSeacrhPriorVal.SelectedItem.ToString());
                    break;
                case 2:
                    resultQuery = MainForm.EventsManager.GetSearchedList(checkBoxSearchInRes.Checked ? resultQuery : null, EventManagerFacade.SearchType.Date, dateTimePicker1.Value.ToString());
                    break;
                case 3:
                    if (CheckSearchedText(out text))
                        resultQuery = MainForm.EventsManager.GetSearchedList(checkBoxSearchInRes.Checked ? resultQuery : null, EventManagerFacade.SearchType.Description, text);
                    else
                        unacceptebleData = true;
                    break;
            }

            if (resultQuery == null || resultQuery.Count() == 0)
            {
                if (unacceptebleData)
                    MessageBox.Show("Поиск не удался из-за некорректных поисковых данных!");
                else
                    MessageBox.Show("Поиск не дал результатов");
                listBoxEvents.DataSource = null;
            }
            else
            {
                SetDataToList(resultQuery);
            }
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            SetDataToList();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            (new AddOrEditEventForm()).ShowDialog(this);
            SetDataToList(resultQuery);
        }

        private void buttonEditEvent_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать элемент для редактиврования!");
                return;
            }
            DialogResult dialogResult = (new AddOrEditEventForm((MyEvent)listBoxEvents.SelectedItem)).ShowDialog(this);
            if (dialogResult == DialogResult.Yes)
            {
                SetDataToList(resultQuery);
            }
        }

        private void buttonDelEvent_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать элемент для удаления!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить запись: '{listBoxEvents.SelectedItem}'?", "Удаление элемента!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainForm.EventsManager.RemoveEvent((MyEvent)listBoxEvents.SelectedItem);
                SetDataToList(resultQuery);
            }
        }
    }
}
