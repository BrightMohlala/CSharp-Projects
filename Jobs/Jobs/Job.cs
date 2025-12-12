class Job : IJob
{
    //Properties
    public int JobNumber { get; protected set; }
    public Car car { get; protected set; }

    //Constructor
    public Job(int jobNumber, Car car)
    {
        this.JobNumber = jobNumber;
        this.car = car;
    } //ctor

    public void SetCar(string registration, string make, string model, int odo)
    {
        car = new Car(registration, make, model, odo);
    } //SetVehicle

    public Car GetCar() => car;

    public IJob Clone(int jobNumber)
    {
        IJob clone = new Job(jobNumber,
                             new Car(car.Registration, car.Make, car.Model, car.Odometer)
                            );
        return clone;
    } //Clone

    public override string ToString()
    {
        return  "\tJob number : " + JobNumber.ToString() + "\n"
              + "\tCar        : " + car.ToString() + "\n";
    } //ToString

} //class Job

