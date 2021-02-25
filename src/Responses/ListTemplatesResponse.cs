using System.Collections.Generic;
using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Responses
{
    public interface ListTemplatesResponse
    {
        int Page { get; set; }
        int PageSize { get; set; }
        int RecordsInPage { get; set; }
        int TotalPages { get; set; }
        string FilterBy { get; set; }
        string OrderBy { get; set; }
        Sorting Sorting { get; set; }
        List<TemplateResponse> Items { get; set; }
    }
}