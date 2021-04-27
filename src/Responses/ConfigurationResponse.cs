using System;
using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Responses
{
    public interface ConfigurationResponse
    {
        string Id { get; set; }
        string AccountId { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        public Provider Provider { get; set; }
        public List<IConfigurationContract> Contracts { get; set; }
        public bool Enabled { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}