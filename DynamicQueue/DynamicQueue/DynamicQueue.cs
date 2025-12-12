using System.Collections.Generic;

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
        head = null;
        tail = null;
        Count = 0;
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

    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;
        while (current != null)
        {
            yield return current.element;
            current = current.Next;
        } //while
    } //GetEnumerator

    public void InsertAt(T item, int position)
    {
        Node newNode = new Node(item);
        if (this.head == null) //Empty queue - this is the first element to be added
            this.head = newNode;
        else
        {
            //Step through existing nodes and find position of new node.
            Node prev = null, current = head;
            int i = 0;
            while (i < Count && i < position)
            {
                prev = current;
                current = current.Next;
                i++;
            }

            //Insert new node between prev and current
            if (prev != null)
                prev.Next = newNode;
            else //current is the head, new node goes to the front
                head = newNode;
            newNode.Next = current;
            if (current == null) //New node after the current tail
                tail = newNode;
        } //else
        Count++;
    }  //Insert



    #endregion Queue operations

} //class DynamicQueue



