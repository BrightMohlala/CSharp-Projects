interface IQueue<T>
{
    int Count { get; }
    void Enqueue(T item);
    T Dequeue();
    T Peek();

    T this[int i] { get; }
    IIterator<T> CreateIterator();
} //interface IQueue