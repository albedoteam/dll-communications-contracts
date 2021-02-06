using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Commands
{
    public interface SendMessage
    {
        string AccountId { get; set; }
        string TemplateId { get; set; }
        string From { get; set; }
        string Subject { get; set; }
        List<IDestinationAddress> Destinations { get; set; }
        List<IMessageParameter> Parameters { get; set; }
    }
}