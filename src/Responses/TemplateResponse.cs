using System;
using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Responses
{
    public interface TemplateResponse
    {
        string Id { get; set; }
        string AccountId { get; set; }
        string Name { get; set; }
        MessageType MessageType { get; set; }
        ContentType ContentType { get; set; }
        string ContentPattern { get; set; }
        bool Enabled { get; set; }
        List<IContentParameter> ContentParameters { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}