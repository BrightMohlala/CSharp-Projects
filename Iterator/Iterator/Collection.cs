class DynamicQueue<T> : IQueue<T>
{
    #region Private embedded class for individual nodes in the queue
    private class Node
    {
        public T element { get; private set; }
        public Node Next { get; set; } //Recursive definition

        //Constructor
        public Node(T element)
        {
            this.element = element;
            Next = null;
        } //Constructor

    } //embedded class Node
    #endregion Embedded class

    #region private data members of the queue
    private Node head, tail;
    #endregion

    #region Property for count
    public int Count { get; private set; } //Count
    #endregion

    #region Constructor
    //Constructor for the list
    public DynamicQueue()
    {
        Clear();
    } //Constructor
    #endregion

    #region Queue operations

    public void Enqueue(T item)
    {
        //Node new_ = new Node(item, null);
        if (this.head == null) //Empty queue - this is the first element to be added
            this.head = this.tail = new Node(item);
        else //We have existing items - add the new node after the last element
        {
            Node newNode = new Node(item);
            tail.Next = newNode;
            tail = newNode;
        }
        Count++;
    } //Enqueue

    public void Clear()
    {
        head = null;
        tail = null;
        Count = 0;
    } //Clear

    public T Dequeue()
    {
        if (head != null)
        {
            T item = head.element;
            head = head.Next;
            Count--;
            return item;
        }
        return default(T);
    } //Dequeue

    public T Peek()
    {
        if (head != null)
            return head.element;
        else
            return default(T);
    } //Peek

    #endregion Queue operations

    //For Iterator

    //Indexer
    public T this[int index]
    {
        get
        {
            Node current = head;
            int i = 0;
            while (i <= index && current != null)
            {
                if (i == index)
                    return current.element;
                else
                {
                    current = current.Next;
                    i++;
                }
            }
            return default;
        }
    } //Indexer

    //Create iterator
    public IIterator<T> CreateIterator()
    {
        return new Iterator<T>(this);
    } //CreateIterator

} //class DynamicQueue
