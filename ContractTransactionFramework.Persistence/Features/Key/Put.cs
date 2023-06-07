using ContractTransactionFramework.Models;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Features.Key;

public record Put : IRequest<Models.Key>, IKey, IDbCommand
{
    public Guid IntentId { get; set; }
    public string? Value { get; set; }
    public string? KnownSecret { get; set; }
    public bool IsSuppresed { get; set; }
    public DateTimeOffset Created { get; set; }
    public bool CommitChanges { get; set; }
}
