using System;
using System.Collections.Generic;
using System.Linq;

public class Graph<T>
{
    //Private class of nodes - only accessible within the Graph class
    private class Node
    {
        public T Value { get; set; }
        public List<Tuple<Node, double>> Successors { get; set; }

        public Node(T value)
        {
            this.Value = value;
            Successors = new List<Tuple<Node, double>>();
        } //Constructor

        public override string ToString()
        {
            return Value.ToString();
        } //ToString
    } //class Node

    //Private data members and public properties
    private List<Node> nodes;
    public int Size { get { return nodes.Count; } }

    //Constructor
    public Graph()
    {
        nodes = new List<Node>();
    } //Constructor

    //Private helper method to get the node that contains a specific value
    private Node GetNode(T value_)
    {
        return nodes.FirstOrDefault(nde => nde.Value.Equals(value_));
    } //GetNode

    public void AddNode(T u)
    {
        Node U = GetNode(u);
        if (U == default) //If not already in the list of nodes
            nodes.Add(new Node(u));
    } //AddNode

    public void AddSuccessor(T u, T v, double w = 0)
    {
        AddNode(u);
        AddNode(v);
        GetNode(u).Successors.Add(new Tuple<Node, double>(GetNode(v), w));
    } //AddSuccessor

    private List<Tuple<T, double>> GetSuccessors(T u)
    {
        Node U = GetNode(u);
        if (U != default)
        {
            List<Tuple<Node, double>> lstSuccessors = new List<Tuple<Node, double>>();
            foreach (Tuple<Node, double> successor in U.Successors.OrderBy(t => t.Item2))
                lstSuccessors.Add(successor);
            return lstSuccessors.Select(t => new Tuple<T, double>(t.Item1.Value, t.Item2)).ToList();
        }
        else
            return null;
    } //GetSuccessors

    public List<Tuple<T, double>> DFT(T u)
    {
        Node U = GetNode(u);
        List<Tuple<T, double>> lstEdges = new List<Tuple<T, double>>();
        DFT(lstEdges, new Tuple<T, double>(u, 0));
        return lstEdges;
    } //ListAllNodes

    private void DFT(List<Tuple<T, double>> lstEdges, Tuple<T, double> u)
    {
        if (!lstEdges.Contains(u))
        {
            lstEdges.Add(u);
            List<Tuple<T, double>> successors = GetSuccessors(u.Item1);
            foreach (Tuple<T, double> successor in successors)
                DFT(lstEdges, successor);
        } //if
    } //TraverseDFT

} //class Graph


