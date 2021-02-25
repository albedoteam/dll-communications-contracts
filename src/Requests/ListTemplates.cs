using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Requests
{
    public interface ListTemplates
    {
        string AccountId { get; set; }
        bool ShowDeleted { get; set; }
        int Page { get; set; }
        int PageSize { get; set; }
        string FilterBy { get; set; }
        string OrderBy { get; set; }
        Sorting Sorting { get; set; }
    }
}