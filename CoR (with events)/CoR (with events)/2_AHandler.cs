public delegate void delOnHandle(string response);

public abstract class AHandler : IHandler
{
    protected IHandler successor;
    public event delOnHandle OnHandle;

    public void SetSuccessor(IHandler successor)
    {
        this.successor = successor;
    } //SetSuccessor

    public abstract void ProcessRequest(int cents);

    protected void RaiseOnHandle(string response)
    {
        OnHandle?.Invoke(response);
    } //RaiseOnHandle

} //AHandler

