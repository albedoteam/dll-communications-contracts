namespace AlbedoTeam.Communications.Contracts.Common
{
    public interface IConfigurationContract
    {
        MessageType MessageType { get; set; }
        int FreeQuota { get; set; }
        decimal TaxPerMessage { get; set; }
    }
}