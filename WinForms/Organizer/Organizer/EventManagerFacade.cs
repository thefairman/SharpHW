using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Organizer
{
    public class EventManagerFacade
    {
        public enum OrderBy { Date, Priority, Name };
        public enum SearchType { Name, Description, Date, Priority }
        public MyBindingList<MyEvent> MyEvents { get; private set; }
        XmlIO xmlIO;
        public event Action<IEnumerable<IGrouping<DateTime, MyEvent>>> EventsChangedGetNearestEvent;
        public EventManagerFacade()
        {
            MyEvents = new MyBindingList<MyEvent>(new List<MyEvent>());
            xmlIO = new XmlIOAdapter(MyEvents);
            try
            {
                xmlIO.LoadFromXML();
            }
            catch (System.IO.FileNotFoundException) { }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public IEnumerable<IGrouping<DateTime, MyEvent>> GetNearestEvents(DateTime? date = null, int count = 3)
        {
            if (date == null || date == DateTime.MinValue)
                date = DateTime.Now;
            if (count <= 0)
                count = 3;
             return MyEvents?.Where(x => x.EventDate > date).OrderBy(x => x.EventDate).GroupBy(x=>x.EventDate).Take(count);
        }

        void EventsEdited()
        {
            EventsChangedGetNearestEvent?.Invoke(GetNearestEvents());
            try
            {
                xmlIO.SaveToXML();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void AddEvent(MyEvent myEvent)
        {
            if (myEvent == null)
                return;
            MyEvents.Add(myEvent);
            EventsEdited();
        }

        public void RemoveEvent(MyEvent myEvent)
        {
            int index = MyEvents.IndexOf(myEvent);
            if (index < 0)
                return;
            MyEvents.RemoveAt(index);
            EventsEdited();
        }

        public void EditEvent(MyEvent myEvent)
        {
            if (myEvent == null)
                return;
            int index = MyEvents.IndexOf(myEvent);
            if (index < 0)
                return;
            MyEvents[index] = myEvent;
            EventsEdited();
        }

        public IEnumerable<MyEvent> GetSearchedList(IEnumerable<MyEvent> source, SearchType searchType, string key)
        {
            if (source == null)
                source = MyEvents;
            switch (searchType)
            {
                case SearchType.Name:
                    return source.Where(x=>x.Name.ToLower().Contains(key.ToLower()));
                case SearchType.Description:
                    return source.Where(x => x.Description.ToLower().Contains(key.ToLower()));
                case SearchType.Date:
                    if (DateTime.TryParse(key, out DateTime sDate))
                        return source.Where(x => x.EventDate.Date == sDate.Date);
                    else
                        return new List<MyEvent>();
                case SearchType.Priority:
                    if (Enum.TryParse(key, out EventPriority prior))
                        return source.Where(x => x.Priority == prior);
                    else
                        return new List<MyEvent>();
                default:
                    return new List<MyEvent>();
            }
        }

        public IEnumerable<MyEvent> GetSortQuery(OrderBy orderBy = OrderBy.Date, bool descending = false)
        {
            if (MyEvents == null)
                return null;
            switch (orderBy)
            {
                case OrderBy.Date:
                    if (descending)
                        return MyEvents.OrderByDescending(x => x.EventDate).ThenBy(x => x.Name);
                    else
                        return MyEvents.OrderBy(x => x.EventDate).ThenBy(x => x.Name);
                case OrderBy.Priority:
                    if (descending)
                        return MyEvents.OrderByDescending(x=>x.Priority).ThenBy(x => x.Name);
                    else
                        return MyEvents.OrderBy(x => x.Priority).ThenBy(x => x.Name);
                case OrderBy.Name:
                    if (descending)
                        return MyEvents.OrderByDescending(x => x.Name).ThenBy(x => x.EventDate);
                    else
                        return MyEvents.OrderBy(x => x.Name).ThenBy(x => x.EventDate);
                default:
                    return null;
            }
        }
    }
}
