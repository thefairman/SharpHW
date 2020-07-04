using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    public enum EventPriority { High, Medium, Low }

    public class MyEvent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public DateTimeOffset Duration { get; set; } = new DateTimeOffset();
        public EventPriority Priority { get; set; } = EventPriority.Medium;

        public override string ToString()
        {
            return Name;
        }
    }
}
