
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT8Q3_TM
{
    public class Remove_by_replace<T> : ARemove<T> where T: IComparable<T>
    {
        protected override void RemoveAt(ref T[] array, int index)
        {
            while (index < array.Length - 1)
            {
                array[index] = array[index + 1];
                index++;
            }
            Array.Resize(ref array, array.Length - 1);
        }
    } //class

    public class Remove_by_temp_array<T> : ARemove<T> where T: IComparable<T>
    {
        protected override void RemoveAt(ref T[] array, int index)
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

    public class Remove_by_conversion<T> : ARemove<T> where T : IComparable<T>
    {
        protected override void RemoveAt(ref T[] array, int index)
        {
            List<T> list = array.ToList<T>();
            list.RemoveAt(index);
            array = list.ToArray<T>();
        }
    } //class Remove_by_convert_list
} //namespace
