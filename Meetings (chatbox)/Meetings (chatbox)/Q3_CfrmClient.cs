
using CT6Q2_Meetings;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class CfrmClient : Form
{
    private IMediator mediator = new Mediator();

    //Constructor
    public CfrmClient()
    {
        InitializeComponent();

        Left = 400; Top = 200;
    } //ctor

    private void btnAddParticipant_Click(object sender, EventArgs e)
    {
        string participantName = Microsoft.VisualBasic.Interaction.InputBox("Participant name:", "Add participant");
        if (!String.IsNullOrEmpty(participantName))
            mediator.AddParticipant(new CfrmParticipant(mediator, participantName));
    } //btnAddParticipant_Click
}

