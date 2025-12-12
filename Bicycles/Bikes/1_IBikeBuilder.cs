namespace Bikes
{
    interface IBikeBuilder
    {
        Biketype GetBiketype();
        void SetBasics();
        void SetRider();
        void SetAccessories();
    } //IBikeBuilder
} //namespace
