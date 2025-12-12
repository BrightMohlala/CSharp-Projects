using System;

class Supervisor
{
    //Supervisor attributes
    public int SupNumber { get; private set; }
    public string SupSurname { get; private set; }
    public string SupCell { get; private set; }
    public DateTime SupDate { get; private set; }

    //Constructor
    public Supervisor(int Number, string Surname, string Cell, DateTime Date)
    {
        SupNumber = Number;
        SupSurname = Surname;
        SupCell = Cell;
        SupDate = Date;
    } //Constructor

    public override string ToString()
    {
        return SupNumber.ToString() + "," + SupSurname + "," + SupCell + "," + SupDate.ToString("dd/MM/yyyy");
    } //ToString

} //class Supervisor
