using ContractTransactionFramework.Features.TransactionLedgerHash;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;

public record Get : IRequest<IEnumerable<Models.TransactionLedgerHash>>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
