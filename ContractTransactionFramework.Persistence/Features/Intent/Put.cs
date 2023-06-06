using ContractTransactionFramework.Models;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Features.Intent;

public record Put : IRequest<Models.Intent>, IIntent, IDbCommand
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsSuppresed { get; set; }
    public DateTimeOffset Created { get; set; }
    public bool CommitChanges { get; set; }
}
