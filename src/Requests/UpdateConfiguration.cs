using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Requests
{
    public interface UpdateConfiguration
    {
        string Id { get; set; }
        string Name { get; set; }
        string Provider { get; set; }
        List<IConfigurationContract> Contracts { get; set; }
        bool Enabled { get; set; }
    }
}