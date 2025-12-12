
internal class RemoteControl
{
    public void ExecuteCommand(ICommand command, Room room)
    {
        command.Execute(room);
    }
} //Invoker

