
public interface IHandler
{
    void SetSuccessor(IHandler successor);
    void ProcessRequest(int cents);
    event delOnHandle OnHandle;

} //IHandler

