using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Features.Key;

public record Post : IRequest<Models.Key>, IKey
{
    public Guid IntentId { get; set; }
    public string? Value { get; set; }
    public string? KnownSecret { get; set; }
    public bool IsSuppresed { get; set; }
    public DateTimeOffset Created { get; set; }
}
