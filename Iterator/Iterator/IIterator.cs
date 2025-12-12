interface IIterator<T>
{
    T Current { get; }
    T First();
    void Next();
} //IIterator