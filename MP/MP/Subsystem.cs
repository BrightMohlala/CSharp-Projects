using System;
using System.Timers;

public class MP
{
    private Timer tmr = new Timer();
    private bool isPlaying = false;
    private int position = 0;

    public MP()
    {
        tmr.Interval = 500;
        tmr.Elapsed += delegate (object sender, ElapsedEventArgs e)
        {
            if (isPlaying)
            {
                Console.Write(position);
                position++;
                position = position % 10;
            }
        };
        tmr.Start();
    } //ctor

    public void Play()
    {
        isPlaying = true;
    }

    public void Pause()
    {
        isPlaying = false;
    }

    public void Stop()
    {
        isPlaying = false;
        position = 0;
    }


} //class MP

