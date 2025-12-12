public abstract class AHandler : IHandler
{
    protected IHandler successor;

    public void SetSuccessor(IHandler successor)
    {
        this.successor = successor;
    } //SetSuccessor

    public abstract void ProcessRequest(int cents);
} //AHandler

