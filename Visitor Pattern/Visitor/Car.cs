
namespace CT9Q2_Visitor
{
    public class Car : IElement
    {
        public string Registration { get; set; }
        public int Odometer { get; set; }

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        } //Accept
    } //class Car
}
