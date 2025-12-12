using System.Collections.Generic;

public interface IMediator
{
    void AddParticipant(CfrmParticipant participant);
    void RelayMessage(CfrmParticipant sender, string message, List<CfrmParticipant> receivers);
}