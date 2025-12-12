
using System;
using System.Collections.Generic;
using System.Linq;

namespace CT8Q2_Strategy
{
    public class Remove_by_replace<T> : IRemoveStrategy<T>
    {
        public void RemoveAt(ref T[] array, int index)
        {
            while (index < array.Length - 1)
            {
                array[index] = array[index + 1];
                index++;
            }
            Array.Resize(ref array, array.Length - 1);
        }
    } //class Remove_by_replace

    public class Remove_by_temp_array<T> : IRemoveStrategy<T>
    {
        public void RemoveAt(ref T[] array, int index)
        {
            T[] tmp = new T[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    tmp[j] = array[i];
                    j++;
                }
            }
            array = tmp;
        } //RemoveAt
    } //class Remove_by_new_array

    public class Remove_by_conversion<T> : IRemoveStrategy<T>
    {
        public void RemoveAt(ref T[] array, int index)
        {
            //List<T> list = array.ToList<T>();
            List<T> list = new List<T>(array);
            list.RemoveAt(index);
            array = list.ToArray();
        }
    } //class Remove_by_convert_list

} //namespace
