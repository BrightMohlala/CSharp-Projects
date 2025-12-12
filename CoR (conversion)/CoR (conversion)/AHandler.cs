
public abstract class AHandler : IHandler
{
    protected IHandler successor;

    public abstract dynamic Cast(string input);

    public void SetSuccessor(IHandler successor)
    {
        this.successor = successor;
    } //SetSuccessor
} //AHandler

