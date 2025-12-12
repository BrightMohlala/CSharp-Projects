using System;

internal class PersonDecorator : IPerson
{
    //Wrappee
    protected IPerson person;

    //Passed through properties
    public string Surname => person.Surname;
    public string Name => person.Name;
    public string ID_number => person.ID_number;

    //Decorated property
    public DateTime DOB { get; private set; }

    //ctor
    public PersonDecorator(IPerson person)
    {
        this.person = person;

        string tmpID = person.ID_number;
        if (int.Parse(person.ID_number.Substring(0, 2)) < 25)
            tmpID = "20" + tmpID;
        else
            tmpID = "19" + tmpID;

        DOB = new DateTime(int.Parse(tmpID.Substring(0, 4)),
                           int.Parse(tmpID.Substring(4, 2)),
                           int.Parse(tmpID.Substring(6, 2)));
    } //ctor
} //class

