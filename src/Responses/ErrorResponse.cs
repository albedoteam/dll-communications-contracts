using AlbedoTeam.Communications.Contracts.Common;

namespace AlbedoTeam.Communications.Contracts.Responses
{
    public interface ErrorResponse
    {
        ErrorType ErrorType { get; set; }
        string ErrorMessage { get; set; }
    }
}