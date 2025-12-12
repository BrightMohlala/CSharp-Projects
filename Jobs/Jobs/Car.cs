/* CSIS2664, 2025
 * Class test 1, Question 3
 * P Blignaut
 * June 2025
 */

class Car
{
    //Properties
    public string Registration { get; private set; }
    public string Make { get; private set; }
    public string Model { get; private set; }
    public int Odometer { get; private set; }

    //ctor
    public Car(string registration, string make, string model, int odo)
    {
        this.Registration = registration;
        this.Make = make;
        this.Model = model;
        Odometer = odo;
    } //ctor

    //Public setters
    public void SetRegistration(string registration) => this.Registration = registration;
    public void SetOdo(int odo) => this.Odometer = odo;

    //ToString
    public override string ToString()
    {
        return Registration + ", " + Make + ", " + Model + ", " + Odometer;
    } //ToString

} //class Vehicle

