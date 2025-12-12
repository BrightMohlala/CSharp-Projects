
public interface IHandler
{
    void SetSuccessor(IHandler successor);
    dynamic Cast(string input);
} //IHandler