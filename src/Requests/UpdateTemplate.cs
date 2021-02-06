﻿using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Requests
{
    public interface UpdateTemplate
    {
        string Id { get; set; }

        string Name { get; set; }

        string MessageType { get; set; }

        string ContentType { get; set; }

        string ContentPattern { get; set; }

        bool Enabled { get; set; }

        List<IContentParameter> ContentParameters { get; set; }
    }
}