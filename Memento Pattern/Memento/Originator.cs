namespace Ct6Q3v2_Memento
{
    public class Item
    {
        //Properties
        public int id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        //Constructor
        public Item(string name, int qty, int id = 0)
        {
            this.id = id;
            this.Name = name;
            this.Quantity = qty;
        } //ctor

        #region Memento
        public class Memento
        {
            public int id { get; private set; }
            public string Name { get; private set; }
            public int Quantity { get; private set; }

            public Memento(int id, string name, int qty)
            {
                this.id = id;
                this.Name = name;
                this.Quantity = qty;
            } //Memento
        } //class Memento

        public Memento SaveToMemento()
        {
            return new Memento(id, Name, Quantity);
        } //SaveToMemento

        public void RestoreFromMemento(Memento memento)
        {
            this.id = memento.id;
            this.Name = memento.Name;
            this.Quantity = memento.Quantity;
        } //RestoreFromMemento

        #endregion Memento

    } //class Item
} //namespace
