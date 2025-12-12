using System;
using System.Collections.Generic;

namespace SimpleCSEC
{
    public class StaticList<T>: IStaticList<T>
    {
        private T[] arr;
        public int Count { get; private set; }

        public StaticList(int capacity = 4)
        {
            this.arr = new T[capacity];
            this.Count = 0;
        } //Constructor

        public void Clear()
        {
            arr = new T[4]; Count = 0;
        } //Clear

        //Indexer - essential to access elements from outside
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                    return arr[index];
                return default;
            }
            set
            {
                if (index >= 0 && index < Count)
                    arr[index] = value;
            }
        } //Indexer
        //public T this[int i] => arr[i];

        public void Add(T item)
        {
            GrowIfArrayIsFull();
            this.arr[this.Count] = item;
            Count++;
        } //Add

        //Expand array to double its size if it is full
        //- Private: Only for internal use
        //private void GrowIfArrayIsFull()
        //{
        //    if (this.Count + 1 > this.arr.Length)
        //    {
        //        T[] extendedArray = new T[this.arr.Length * 2];
        //        for (int i = 0; i < this.Count; i++)
        //            extendedArray[i] = arr[i];
        //        this.arr = extendedArray; 
        //    } //if arr is full
        //} //GrowIfArrayIsFull

        private void GrowIfArrayIsFull()
        {
            if (this.Count + 1 > this.arr.Length)
                Array.Resize<T>(ref arr, this.arr.Length * 2);
        } //GrowIfArrayIsFull

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return arr[i];
            //return (IEnumerator<T>)arr.GetEnumerator(); //Does not work

        } //GetEnumerator

    } //class StaticList
} //namespace
