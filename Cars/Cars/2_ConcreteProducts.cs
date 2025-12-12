/* CSIS2664, 2025
 * Class test 2, Question 1
 * Student number:2079034130
 * Surname, Initials: Blignaut, PJ
 */

class Honda : ACar
{
    public Honda(string model, string colour)
    {
        this.model = model;
        this.colour = colour;
    }
} //class Honda

class BMW : ACar
{
    //private string model, colour;

    //public string CarColor
    //{
    //    get { return colour; }
    //}

    public BMW(string model, string colour)
    {
        this.model = model;
        this.colour = colour;
    }


    public string GetCarModel()
    {
        return model;
    }
} //class BMW
