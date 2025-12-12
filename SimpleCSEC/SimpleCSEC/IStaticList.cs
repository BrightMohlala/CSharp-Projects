using System.Collections.Generic;

namespace SimpleCSEC
{
    public interface IStaticList<T>
    {
        int Count { get; }
        void Clear();
        T this[int i] { get; }
        void Add(T item);
        IEnumerator<T> GetEnumerator();
    } //interface IStaticList
}
