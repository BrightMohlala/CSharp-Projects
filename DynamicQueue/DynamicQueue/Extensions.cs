using Playground_queue;
using System;
using System.Collections.Generic;

namespace PlaygroundQ
{
    internal static class Extensions
    {
        public static bool IsEmpty(this IQueue<Toddler> q)
        {
            return q.Count == 0;
        } //IsEmpty

        public static List<Toddler> ToList(this IQueue<Toddler> q)
        {
            //Several alternatives

            //return [.. q]; //C# v12 only

            //List<Toddler> lst = [.. q]; //C# v12 only
            //return lst;

            //List<Toddler> lst = new();
            //foreach (Toddler t in q)
            //    lst.Add(t);
            //return lst;

            List<Toddler> lst = new List<Toddler>();
            foreach (Toddler t in q)
                lst.Add(t);
            return lst;

        } //ToList

        public static void InsertBefore(this IQueue<Toddler> q, Toddler t1, string t2)
        {
            /*
            int i = 0, pos = -1;
            foreach (Toddler t in q)
            {
                if (t.Name == t2)
                {
                    pos = i;
                    break;
                }
                else
                    i++;
            }

            if (pos >= 0)
                q.Insert(t1, pos);
            */

            int pos = -1;
            for (int i = 0; i < q.ToList().Count; i++)
            {
                if (q.ToList()[i].Name == t2)
                    pos = i;
            }
            if (pos >= 0)
                q.InsertAt(t1, pos);

        } //InsertBefore

        public static IQueue<Toddler> Remove(this IQueue<Toddler> q, string toRemove)
        {
           // List<Toddler> lst = q.ToList();
            IQueue<Toddler> tempQ = new DynamicQueue<Toddler>();

            //foreach (Toddler t in lst)
            //{
            //    if(t.Name != toRemove)
            //    {
            //        tempQ.Enqueue(t); //add the names excluding the one removed to a new queue
            //    }
            //}
            //return tempQ;

            //IQueue<Toddler> tempQ = new DynamicQueue<Toddler>();
            //while (q.Count > 0)
            //while (!q.IsEmpty())
            //{
            //    Toddler t = q.Dequeue();
            //    if (t.Name != toRemove)
            //        tempQ.Enqueue(t);
            //}
            //return tempQ;

            foreach (Toddler t in q)
                if (t.Name != toRemove)
                    tempQ.Enqueue(t);
            return tempQ;
        } //Remove

    } //Extensions
} //namespace
