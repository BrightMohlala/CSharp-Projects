class Author
{
    public string SurnameInitials { get; }
    public int NumberOfBooks { get; set; }
    public decimal TotalPrice { get; set; }

    public Author(string surnameInitials, int nBooks, decimal totalPrice)
    {
        SurnameInitials = surnameInitials;
        NumberOfBooks = nBooks;
        TotalPrice = totalPrice;
    } //ctor
} //class Author

