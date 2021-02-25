namespace AlbedoTeam.Communications.Contracts.Requests
{
    public interface GetTemplate
    {
        string AccountId { get; set; }
        string Id { get; set; }
        bool ShowDeleted { get; set; }
    }
}