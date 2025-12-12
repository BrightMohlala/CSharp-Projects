using System.Collections.Generic;

namespace Ct6Q3v2_Memento
{
    public class ctItem
    {
        //Members
        //- Item
        public Item item { get; private set; }
        public int id => item.id;
        public string Name => item.Name;
        public int Quantity => item.Quantity;

        //- History
        private Stack<Item.Memento> history = new Stack<Item.Memento>();

        //- DB helper
        private IDB dbhelper = DBhelper.GetInstance();

        //Constructor
        public ctItem(Item item)
        {
            this.item = item;
        } //ctor

        #region static methods (DB methods)

        public static List<ctItem> GetCaretakers()
        {
            //Get items from DB
            IDB dbhelper = DBhelper.GetInstance();
            List<Item> items = dbhelper.GetItems();

            //Create caretaker for each item
            List<ctItem> caretakers = new List<ctItem>();
            foreach (Item item in items)
                caretakers.Add(new ctItem(item));

            //Return caretakers
            return caretakers;
        } //GetCareTakers

        public static ctItem AddItem(string item_name, int quantity)
        {
            //Create new item
            Item item = new Item(item_name, quantity);

            //Save new item to DB
            IDB dbhelper = DBhelper.GetInstance();
            dbhelper.AddItem(item);

            //Create and return new caretaker
            return new ctItem(item);
        } //AddItem

        public static void DeleteItem(int id)
        {
            IDB dbhelper = DBhelper.GetInstance();
            dbhelper.DeleteItem(id);
        } //DeleteItem

        #endregion static methods

        #region instance methods

        public void EditItem(string item_name, int quantity)
        {
            //Save memento of current item
            history.Push(item.SaveToMemento());
            
            //Edit current item
            item.Name = item_name;
            item.Quantity = quantity;

            //Save changes
            dbhelper.UpdateItem(item);
        } //EditItem

        public void Restore()
        {
            if (history.Count > 0)
            {
                //Restore current item
                item.RestoreFromMemento(history.Pop());

                //Save changes
                dbhelper.UpdateItem(item);
            }
        } //Restore

        #endregion instance methods

    } //class ctItem
} //namespace
