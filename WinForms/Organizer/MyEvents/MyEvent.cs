using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    public enum EventPriority { High, Medium, Low }

    public class MyEvent : IEquatable<MyEvent>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan Duration { get; set; } = TimeSpan.Zero;
        public EventPriority Priority { get; set; } = EventPriority.Medium;
        public Guid Guid { get; set; } = Guid.NewGuid();

        public bool Equals(MyEvent other)
        {
            return Guid == other.Guid;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
