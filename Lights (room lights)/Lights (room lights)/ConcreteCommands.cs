

public class LightOn : ICommand
{
    public void Execute(Room room)
    {
        room?.Switch(true);
    } //Execute

} //class LightOn

public class LightOff : ICommand
{
    public void Execute(Room room)
    {
        room?.Switch(false);
    } //Execute
} //class LightOff