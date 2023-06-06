using ContractTransactionFramework.Models;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Features.Contract;

public record Put : IRequest<Models.Contract>, IContract, IDbCommand
{
    public Guid? TransactionId { get; set; }
    public Guid? ContractId { get; set; }
    public string? Name { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
    public bool CommitChanges { get; set; }
}
