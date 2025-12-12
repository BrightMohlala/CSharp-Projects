class Iterator<T> : IIterator<T>
{
    //Private members
    private IQueue<T> queue;
    private int index;

    //Constructor
    public Iterator(IQueue<T> queue)
    {
        this.queue = queue;
        index = -1;
    } //Constructor

    //Navigation
    //public T Current
    //{
    //    get
    //    {
    //        return queue[index];
    //    }
    //} //Current
    public T Current => queue[index];

    public T First()
    {
        index = 0;
        return queue[index];
    } //First

    public void Next()
    {
        index++;
    } //Next
} //class Iterator