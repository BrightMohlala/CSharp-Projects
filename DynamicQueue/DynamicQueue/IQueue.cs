using System.Collections.Generic;

public interface IQueue<T>
{
    void Enqueue(T value);
    T Dequeue();
    int Count { get; }
    void InsertAt(T value, int position);
    IEnumerator<T> GetEnumerator();
} //interface   