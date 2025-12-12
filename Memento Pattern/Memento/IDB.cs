using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ct6Q3v2_Memento
{
    public interface IDB
    {
        List<Item> GetItems();
        void AddItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(int id);
    } //interface IDB
}
