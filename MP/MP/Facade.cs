//Delegate for position changed
public delegate void delOnPositionChanged(int seconds, int vol);

//Facade for WindowsMediaPlayer
class MPFacade
{
    //Sub-system class for which a facade is created
    private MP mp = new MP();

    //Execute commands
    public void Play() => mp.Play();
    public void Pause() => mp.Pause();
    public void Stop() => mp.Stop();

} //class MPFacade

