using System;
using System.Collections.Generic;
using System.Linq;

namespace Q4_Irrigation_network
{
    internal class Client
    {
        static void Main(string[] args)
        {
            //Black on white
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();

            //Create graph
            Graph<string> graph = CreateGraph();

            //Nodes from V1 (Depth-first)
            ListAllWithCost(graph, "V1");

            //Done
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        } //Main

        private static Graph<string> CreateGraph()
        {
            //Instantiate the graph object
            Graph<string> graph = new Graph<string>();

            //Create nodes
            graph.AddNode("S");
            graph.AddNode("V1"); graph.AddNode("V2"); graph.AddNode("V3"); graph.AddNode("V4");
            graph.AddNode("T1"); graph.AddNode("T2"); graph.AddNode("T3"); graph.AddNode("T4"); graph.AddNode("T5"); graph.AddNode("T6");
            graph.AddNode("O1"); graph.AddNode("O2"); graph.AddNode("O3"); graph.AddNode("O4"); graph.AddNode("O5"); graph.AddNode("O6");
            graph.AddNode("P1");

            //Add successors
            graph.AddSuccessor("S", "V1", 3);
            graph.AddSuccessor("V1", "T1", 1);
            graph.AddSuccessor("T1", "T2", 1); graph.AddSuccessor("T2", "T3", 1); graph.AddSuccessor("T3", "T4", 1);
            graph.AddSuccessor("T4", "T5", 1); graph.AddSuccessor("T5", "T6", 1); 
            graph.AddSuccessor("T1", "O1", 0.5); graph.AddSuccessor("T2", "O2", 0.5); graph.AddSuccessor("T3", "O3", 0.5);
            graph.AddSuccessor("T4", "O4", 0.5); graph.AddSuccessor("T5", "O5", 0.5); 
            graph.AddSuccessor("T6", "O6", 0.5); graph.AddSuccessor("T6", "P1", 1);

            return graph;
        } //CreateGraph

        private static void ListAllWithCost(Graph<string> graph, string startNode)
        {
            //Get all successors with associated cost
            List<Tuple<string, double>> edges = graph.DFT(startNode);

            //- Display all edges
            Console.WriteLine("\tAll nodes DFT from " + startNode + ": " + String.Join(", ", edges.Select(e => e.Item1)));
            double totalCost = edges.Select(e => e.Item2).Sum();
            Console.WriteLine("\tTotal cost : " + totalCost);

        } //ListAllWithCost
    } //class Client
} //namespace
