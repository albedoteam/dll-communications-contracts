﻿namespace AlbedoTeam.Communications.Contracts.Requests
{
    public interface GetConfiguration
    {
        string Id { get; set; }
        bool ShowDeleted { get; set; }
    }
}