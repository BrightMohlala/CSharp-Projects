/* CSIS2664, 2025
 * Class test 1, Question 3
 * P Blignaut
 * June 2025
 */

interface IJob
{
    //Properties
    int JobNumber { get; }
    Car car { get; }

    //Methods
    void SetCar(string registration, string make, string model, int odo);
    Car GetCar();
    IJob Clone(int jobNumber);
    string ToString();
} //class IJob

