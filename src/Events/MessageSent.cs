using System;
using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Events
{
    public interface MessageSent
    {
        string Id { get; set; }
        string AccountId { get; set; }
        Provider Provider { get; set; }
        MessageType MessageType { get; set; }
        string From { get; set; }
        string Subject { get; set; }
        ContentType ContentType { get; set; }
        string Content { get; set; }
        List<IDestinationAddress> Destinations { get; set; }
        DateTime? SentAt { get; set; }
        string Status { get; set; }
        string DetailMessage { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}