using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    public class MyBindingList<T> : BindingList<T>
    {
        List<T> originalList;
        public MyBindingList(List<T> list) : base(list)
        {
            originalList = list;
        }

        public void Sort()
        {
            originalList.Sort();
            this.ResetBindings();
        }

        public void Sort(IComparer<T> comparer)
        {
            originalList.Sort(comparer);
            this.ResetBindings();
        }

        public void Sort(Comparison<T> comparison)
        {
            originalList.Sort(comparison);
            this.ResetBindings();
        }

        public void Sort(int index, int count, IComparer<T> comparer)
        {
            originalList.Sort(index, count, comparer);
            this.ResetBindings();
        }
    }
}
