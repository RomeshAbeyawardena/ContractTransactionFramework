using ContractTransactionFramework.Models;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;

public record Put : IRequest<Models.TransactionLedgerHash>, ITransactionLedgerHash, IDbCommand
{
    public Guid TransactionLedgerId { get; set; }
    public string? DataHash { get; set; }
    public bool IsViable { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
    public bool CommitChanges { get; set; }
}
