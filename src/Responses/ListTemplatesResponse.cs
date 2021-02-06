using System.Collections.Generic;

namespace AlbedoTeam.Communications.Contracts.Responses
{
    public interface ListTemplatesResponse
    {
        int Page { get; set; }
        int PageSize { get; set; }
        int RecordsInPage { get; set; }
        int TotalPages { get; set; }
        List<TemplateResponse> Items { get; set; }
    }
}