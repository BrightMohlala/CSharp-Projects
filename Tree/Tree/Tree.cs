using System;
using System.Collections.Generic;
using System.Linq;

class Tree<T>
{
    //Properties
    public T Value { get; private set; }
    private List<Tree<T>> lstChildren { get; set; }

    //Constructor 
    public Tree(T value)
    {
        this.Value = value;
        lstChildren = new List<Tree<T>>();
    } //Constructor 

    //1.3.1
    public void AddChildren(Tree<T>[] children)
    {
        foreach (Tree<T> child in children)
            lstChildren.Add(child);
    }

    //1.3.3
    public List<T> BFT()
    {
        List<T> lstNodes = [];
        Queue<Tree<T>> qVisited = new();
        qVisited.Enqueue(this);  //Enqueue root
        while (qVisited.Count > 0)
        {
            Tree<T> current = qVisited.Dequeue();       //Dequeue
            lstNodes.Add(current.Value);  //Visit
            foreach (Tree<T> child in current.lstChildren) //Enqueue all children
                qVisited.Enqueue(child);
        } //while
        return lstNodes;
    } //TraverseBFT

    //1.3.4
    public List<T> DFT()
    {
        List<T> lstNodes = new List<T>();
        this.DFT(this, lstNodes);
        return lstNodes;
    } //DFT

    private void DFT(Tree<T> node, List<T> lstNodes)
    {
        //Visit node - add to the output
        lstNodes.Add(node.Value);

        //Visit all children (base case is when there are no children)
        foreach (Tree<T> child in node.lstChildren)
            DFT(child, lstNodes);
    } //DFT



} //class Tree

