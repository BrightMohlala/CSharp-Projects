using System.Net.Security;
using System.Windows.Forms;


public partial class CfrmHouse : Form
{
    private ICommand lightOn, lightOff;
    private RemoteControl remote;
    private Room kitchen, bathroom, bedroom1, bedroom2, bedroom3, bedroom4, lounge;

    //Constructor
    public CfrmHouse()
    {
        InitializeComponent();
    } //ctor

    private void CfrmHouse_Load(object sender, System.EventArgs e)
    {
        //Receivers
        kitchen = new Room("Kitchen", pnlKitchen);
        bathroom = new Room("Bathroom", pnlBathroom);
        bedroom1 = new Room("Bedroom 1", pnlBedroom_1);
        bedroom2 = new Room("Bedroom 2", pnlBedroom_2);
        bedroom3 = new Room("Bedroom 3", pnlBedroom_3);
        bedroom4 = new Room("Bedroom 4", pnlBedroom_4);
        lounge = new Room("Lounge", pnlLounge);

        //Invoker
        remote = new RemoteControl();

        //Commands
        lightOn = new LightOn();
        lightOff = new LightOff();
    } //CfrmHouse_Load

    //For Remote 1
    private void btnOK_Click(object sender, System.EventArgs e)
    {
        //Identify command
        ICommand command = radOn.Checked ? lightOn : lightOff;

        //Identify receiver
        Room room = radBathroom.Checked ? bathroom
                          : radBedroom1.Checked ? bedroom1
                          : radBedroom2.Checked ? bedroom2
                          : radBedroom3.Checked ? bedroom3
                          : radBedroom4.Checked ? bedroom4
                          : radKitchen.Checked ? kitchen
                          : radLounge.Checked ? lounge
                          : null;
        
        //Invoker
        remote.ExecuteCommand(command, room);
    } //btnOK_Click

    //For Remote 2
    private void chBathroom_CheckedChanged(object sender, System.EventArgs e)
    {
        //Command
        ICommand command = ((CheckBox)sender).Checked ? lightOn : lightOff;

        //Receiver
        Room room = ((Control)sender).Name == "chBathroom" ? bathroom
                        : ((Control)sender).Name == "chBedroom1" ? bedroom1
                        : ((Control)sender).Name == "chBedroom2" ? bedroom2
                        : ((Control)sender).Name == "chBedroom3" ? bedroom3
                        : ((Control)sender).Name == "chBedroom4" ? bedroom4
                        : ((Control)sender).Name == "chKitchen" ? kitchen
                        : ((Control)sender).Name == "chLounge" ? lounge
                        : null;
        
        //Invoker
        remote.ExecuteCommand(command, room);
    } //chBathroom_CheckedChanged
} //class CfrmHouse

