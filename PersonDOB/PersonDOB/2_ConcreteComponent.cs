
internal class Person : IPerson
{
    public string Surname { get; private set; }
    public string Name { get; private set; }
    public string ID_number { get; private set; }

    public Person(string surname, string name, string id)
    {
        Surname = surname;
        Name = name;
        ID_number = id;
    } //ctor
} //class Person

