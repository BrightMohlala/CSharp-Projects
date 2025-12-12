using System.Collections.Generic;

public class Mediator : IMediator
{
    //Mediator keeps a list of all components (participants)
    private List<CfrmParticipant> participants = new List<CfrmParticipant>();

    //Used for participant form top to ensure that different instances do not overlap
    private int top = 0;

    //Add participant
    public void AddParticipant(CfrmParticipant participant)
    {
        //Add articipant to list
        participants.Add(participant);
        
        //Inform all current participants of the new attendee
        foreach (CfrmParticipant p in participants)
            p.UpdateParticipants(participants);

        //Show the form for the new participant
        participant.Left = 800;
        participant.Top = top;
        top += participant.Height;
        participant.Show();
    } //AddParticipant

    //Relay message
    public void RelayMessage(CfrmParticipant sender, string message, List<CfrmParticipant> receivers)
    {
        foreach (CfrmParticipant participant in receivers)
            participant.GetMessage(sender, message);
    } //RelayMessage
} //class Mediator

