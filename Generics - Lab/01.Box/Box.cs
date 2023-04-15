using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    class Box<T>
    {
        public Box()
        {
            List = new List<T>();
        }
        public List<T> List { get; set; }
        public int Count { get { return List.Count; } }
        public void Add(T element)
        {
            List.Add(element);
        }
        public T Remove()
        {
            T elementToRemove = List[List.Count-1];
            List.Remove(elementToRemove);
            return elementToRemove;
        }

    }
}
