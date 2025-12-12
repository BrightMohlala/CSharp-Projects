using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class CfrmParticipant : Form
{
    //Every component should know who the mediator is
    private IMediator mediator;

    public CfrmParticipant(IMediator mediator, string name)
    {
        //Design form controls
        InitializeComponent();

        //Display participant name in title bar
        Text = name;

        //Set mediator
        this.mediator = mediator;
    } //ctor

    public void UpdateParticipants(List<CfrmParticipant> participants)
    {
        //Update list of participants
        chlstbxRecipients.DataSource = null;
        chlstbxRecipients.DataSource = participants;
        chlstbxRecipients.DisplayMember = "Text";

        //Select all participants as recipients by default
        for (int i = 0; i < chlstbxRecipients.Items.Count; i++)
            chlstbxRecipients.SetItemChecked(i, true);
    } //UpdateParticipants

    private void btnSend_Click(object sender, System.EventArgs e)
    {
        //If no message, return
        if (txtMessageOut.Text == "")
            return;

        //Send message to all checked recipients
        mediator.RelayMessage(this, txtMessageOut.Text, chlstbxRecipients.CheckedItems.Cast<CfrmParticipant>().ToList());

        //Clear message box
        txtMessageOut.Clear();

        //Select all recipients
        for (int i = 0; i < chlstbxRecipients.Items.Count; i++)
            chlstbxRecipients.SetItemChecked(i, true);
    } //btnSend_Click

    public void GetMessage(CfrmParticipant sender, string message)
    {
        if (sender != null)
            lstbxMessagesReceived.Items.Add(sender.Text + ": " + message);
        else
            lstbxMessagesReceived.Items.Add(message);
    } //GetMessage

    private void CfrmParticipant_Load(object sender, System.EventArgs e)
    {

    }
} //class CfrmParticipant

