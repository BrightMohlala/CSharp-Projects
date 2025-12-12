using System.Drawing; //For Color
using System.Windows.Forms; //For Panel

public class Room
{
    //Properties
    public string Name { get; private set; }
    public Panel Panel { get; private set; }

    //Constructor
    public Room(string name, Panel panel)
    {
        this.Name = name;
        this.Panel = panel;
    } //ctor

    public void Switch(bool isOn)
    {
        Panel.BackColor = isOn? Color.LightBlue : Color.Silver;
    } //Switch
} //class Room