namespace Lists_Linq_Events
{
    public class Book
    {
        //Properties
        public string Title { get; private set; }
        public string Authors { get; private set; }
        public decimal Price { get; private set; }

        //ctor
        public Book(decimal price, string title, string authors)
        {
            this.Title = title;
            this.Authors = authors;
            this.Price = price;
        } //ctor

        public override string ToString()
        {
            return Price.ToString("C").PadLeft(10) + "  "
                   + Title.PadRight(30)
                   + Authors;
        } //ToString


    } //class Book
} //namespace
