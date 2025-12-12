namespace Bikes
{
    class Director
    {
        public void BuildBike(IBikeBuilder bikeBuilder)
        {
            bikeBuilder.SetBasics();
            bikeBuilder.SetRider();
            bikeBuilder.SetAccessories();
        } //BuildBike

    } //class Director
}
