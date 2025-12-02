using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FixedSizeList<T>
    {
        public int Capacity {  get; set; }
        public List<T> FixedList { get; set; } = new List<T>();

        public FixedSizeList(int capacity) {
        Capacity = capacity;
        }
        public void Add(T item)
        {
            if (FixedList.Count < Capacity) { FixedList.Add(item); }
            else throw new Exception("Cannot Add Item To This List");
        }
    }
}
