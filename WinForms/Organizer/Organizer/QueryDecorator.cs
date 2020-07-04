using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static Organizer.EventManagerFacade;

namespace Organizer
{
    public abstract class MyComponent<T>
    {
        protected IEnumerable<T> events;
        public abstract IEnumerable<T> GetQuery();
    }

    public class EventComponenet : MyComponent<MyEvent>
    {
        public EventComponenet(IEnumerable<MyEvent> myEvents)
        {
            events = myEvents;
        }
        public override IEnumerable<MyEvent> GetQuery()
        {
            return events;
        }
    }

    public abstract class AbstractQueryBuilderDecorator<T> : MyComponent<T>
    {
        public MyComponent<T> Component { protected get; set; }
        public override IEnumerable<T> GetQuery()
        {
            if (Component != null)
                return Component.GetQuery();
            return null;
        }
    }

    public class EventsOrderedQueryBuilderDecorator : AbstractQueryBuilderDecorator<MyEvent>
    {
        OrderBy orderBy;
        bool descending;
        public EventsOrderedQueryBuilderDecorator(OrderBy orderBy, bool descending = false)
        {
            this.orderBy = orderBy;
            this.descending = descending;
        }
        public override IEnumerable<MyEvent> GetQuery()
        {
            events = base.GetQuery();
            switch (orderBy)
            {
                case OrderBy.Date:
                    if (descending)
                        return events.OrderByDescending(x => x.EventDate).ThenBy(x => x.Name);
                    else
                        return events.OrderBy(x => x.EventDate).ThenBy(x => x.Name);
                case OrderBy.Priority:
                    if (descending)
                        return events.OrderByDescending(x => x.Priority).ThenBy(x => x.Name);
                    else
                        return events.OrderBy(x => x.Priority).ThenBy(x => x.Name);
                case OrderBy.Name:
                    if (descending)
                        return events.OrderByDescending(x => x.Name).ThenBy(x => x.EventDate);
                    else
                        return events.OrderBy(x => x.Name).ThenBy(x => x.EventDate);
                default:
                    return events;
            }
        }
    }

    public class EventsSResultQueryBuilderDecorator : AbstractQueryBuilderDecorator<MyEvent>
    {
        SearchType searchType;
        string key;
        IEnumerable<MyEvent> source;
        public EventsSResultQueryBuilderDecorator(IEnumerable<MyEvent> source, SearchType searchType, string key)
        {
            this.searchType = searchType;
            this.key = key;
            this.source = source;
        }
        public override IEnumerable<MyEvent> GetQuery()
        {
            events = source ?? base.GetQuery();
            switch (searchType)
            {
                case SearchType.Name:
                    return events.Where(x => x.Name.ToLower().Contains(key.ToLower()));
                case SearchType.Description:
                    return events.Where(x => x.Description.ToLower().Contains(key.ToLower()));
                case SearchType.Date:
                    if (DateTime.TryParse(key, out DateTime sDate))
                        return events.Where(x => x.EventDate.Date == sDate.Date);
                    else
                        return events;
                case SearchType.Priority:
                    if (Enum.TryParse(key, out EventPriority prior))
                        return events.Where(x => x.Priority == prior);
                    else
                        return events;
                default:
                    return events;
            }
        }
    }
}
