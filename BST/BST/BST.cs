using System.Collections.Generic;

namespace Question2
{
    public class BST
    {
        //Properties
        public char Value { get; private set; }
        public BST LeftChild { get; private set; }
        public BST RightChild { get; private set; }

        #region Constructor

        //Constructor
        public BST(char value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        } //Constructor

        #endregion Constructors

        #region Add
        public void Add(char value)
        {
            Add(value, this); //value, node
        } //Add

        private BST Add(char value, BST node)
        {
            if (node == null) //Occurs when we reach the bottom of the tree
            {
                node = new BST(value); //The pointer, which was previously null, now becomes something. Thus, parent.Left/Right becomes something.
            }
            else //Still not at the bottom - decide which way to go 
            {
                int compareTo = value.CompareTo(node.Value);
                if (compareTo < 0)
                    node.LeftChild = Add(value, node.LeftChild); //value, node
                else
                    if (compareTo >= 0)
                    node.RightChild = Add(value, node.RightChild); //value, node
            }
            return node;
        } //Add

        #endregion Add

        #region Traversals

        public List<char> BFT()
        {
            List<char> lstNodes = new List<char>();
            Queue<BST> qVisited = new Queue<BST>();
            qVisited.Enqueue(this);
            while (qVisited.Count > 0)
            {
                BST current = qVisited.Dequeue();
                lstNodes.Add(current.Value);
                if (current.LeftChild != null) qVisited.Enqueue(current.LeftChild);
                if (current.RightChild != null)  qVisited.Enqueue(current.RightChild);
            } //while
            return lstNodes;
        } //TraverseBFT

        public List<char> VisitInOrder()
        {
            List<char> lstNodes = new List<char>();
            VisitInOrder(lstNodes); //Start the recursion
            return lstNodes;
        } //VisitInOrder

        private void VisitInOrder(List<char> lstNodes) //Left, Root, Right
        {
            // 1. Visit the left child
            if (this.LeftChild != null)
                this.LeftChild.VisitInOrder(lstNodes);

            // 2. Visit the root of this sub-tree
            lstNodes.Add(this.Value);

            // 3. Visit the right child
            if (this.RightChild != null)
                this.RightChild.VisitInOrder(lstNodes);
        } //VisitInOrder

        public List<char> VisitPreOrder()
        {
            List<char> lstNodes = new List<char>();
            VisitPreOrder(lstNodes); //Start the recursion
            return lstNodes;
        } //VisitPreOrder

        private void VisitPreOrder(List<char> lstNodes) //Left, Root, Right
        {
            // 1. Visit the root of this sub-tree
            lstNodes.Add(this.Value);

            // 2. Visit the left child
            if (this.LeftChild != null)
                this.LeftChild.VisitPreOrder(lstNodes);

            // 3. Visit the right child
            if (this.RightChild != null)
                this.RightChild.VisitPreOrder(lstNodes);
        } //VisitPreOrder

        public List<char> VisitPostOrder()
        {
            List<char> lstNodes = new List<char>();
            VisitPostOrder(lstNodes); //Start the recursion
            return lstNodes;
        } //VisitPostOrder

        private void VisitPostOrder(List<char> lstNodes) //Left, Root, Right
        {
            // 1. Visit the left child
            if (this.LeftChild != null)
                this.LeftChild.VisitPostOrder(lstNodes);

            // 2. Visit the right child
            if (this.RightChild != null)
                this.RightChild.VisitPostOrder(lstNodes);

            // 3. Visit the root of this sub-tree
            lstNodes.Add(this.Value);
        } //VisitPostOrder

        #endregion Traversals

    } //class BST
} //namespace
