namespace CT9Q2_Visitor
{
    public interface IElement
    {
        void AcceptVisitor(IVisitor visitor);
    }
}
