class Employee
{
    //Employee attributes
    public int StaffNumber { get; private set; }
    public string StaffName { get; private set; }
    public int StaffAge { get; private set; }
    public string StaffCell { get; private set; }

    //Supervisor flyweight object
    public Supervisor supervisor { get; private set; }

    //Constructor
    public Employee(int Number, string Name, int age, string Cell, Supervisor supervisor)
    {
        StaffNumber = Number;
        StaffName = Name;
        StaffAge = age;
        StaffCell = Cell;
        this.supervisor = supervisor;
    } //Constructor

    //ToString
    public override string ToString()
    {
        return StaffNumber.ToString() + "," + StaffName + "," + StaffAge + "," + StaffCell + "," 
            + supervisor.ToString();
    } //ToString

} //class Employee
