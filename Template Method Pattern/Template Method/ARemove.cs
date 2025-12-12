
using System;

namespace CT8Q3_TM
{
    public abstract class ARemove<T> where T:IComparable<T>
    {
        protected abstract void RemoveAt(ref T[] entries, int index);

        private int GetIndex(T[] entries, T item)
        {
            int i = 0;
            bool isFound = false;
            while (i < entries.Length && !isFound)
            {
                //if (entries[i].CompareTo(item) == 0)
                //if (item.CompareTo(entries[i]) == 0)
                //if (item.Equals(entries[i]))
                if (entries[i].Equals(item))
                    isFound = true;
                else
                    i++;
            }

            return isFound ? i : -1;
        } //GetIndex

        public void RemoveEntry(ref T[] entries, T item)
        {
            int i = GetIndex(entries, item);
            T[] tmp = entries;
            RemoveAt(ref tmp, i);
            entries = tmp;
        } //RemoveEntry

    } //class ARemoveSteps
} //namespace
