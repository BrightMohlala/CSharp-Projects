
public interface IHandler
{
    void SetSuccessor(IHandler successor);
    void ProcessRequest(int cents);
} //IHandler

