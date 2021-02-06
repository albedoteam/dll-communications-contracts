using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Requests
{
    public interface CreateTemplate
    {
        string AccountId { get; set; }

        string Name { get; set; }

        MessageType MessageType { get; set; }

        ContentType ContentType { get; set; }

        string ContentPattern { get; set; }

        bool Enabled { get; set; }

        List<IContentParameter> ContentParameters { get; set; }
    }
}