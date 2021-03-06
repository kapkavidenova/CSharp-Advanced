using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    public class Box<T> where T: IComparable
    {
        public Box(List<T> value)
        {
            this.Values = value;
        }

        public List<T> Values { get; set; }
        //public void Swap(int a, int b)
        //{
        //    var temprVariables = Values[a];
        //    this.Values[a] = this.Values[b];
        //    this.Values[b] = temprVariables;
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");

            }
            return sb.ToString().TrimEnd();
        }
        //public void Swap(List<T> items, int firstIndex, int secondIndex)
        //{
        //    T tempValue = items[firstIndex];
        //    items[firstIndex] = items[firstIndex];
        //    items[firstIndex] = tempValue;
        //}
        public int CountGreaterElement(List<T>elements, T elementToCompare)
        {
            int counter = 0;
            foreach (var element in elements)
            {
                if (elementToCompare.CompareTo(element)<0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
