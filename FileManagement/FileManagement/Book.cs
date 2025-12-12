internal class Book
{
    public string SurnameInitials   {   get; }
    public string Title { get; }
    public decimal Price { get; }

    public Book(string surnameInitials, string title, decimal price)
    {
        this.SurnameInitials = surnameInitials;
        Title = title;
        Price = price;
    } //ctor

} //class Book
