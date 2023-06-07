using ContractTransactionFramework.Models;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Features.Transaction;

public record Post : IRequest<Models.Transaction>, ITransaction, IDbCommand
{
    public Guid ContractId { get; set; }
    public string? Name { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
    public bool CommitChanges { get; set; }
}
