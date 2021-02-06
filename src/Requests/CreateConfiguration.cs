using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Requests
{
    public interface CreateConfiguration
    {
        string AccountId { get; set; }
        string Name { get; set; }
        Provider Provider { get; set; }
        List<IConfigurationContract> Contracts { get; set; }
        bool Enabled { get; set; }
    }
}