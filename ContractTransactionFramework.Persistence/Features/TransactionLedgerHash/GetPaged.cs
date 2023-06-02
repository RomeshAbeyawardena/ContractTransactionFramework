using ContractTransactionFramework.Features.TransactionLedgerHash;
using RST.Contracts;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;

public record GetPaged : IPagedRequest<Models.TransactionLedgerHash>, IQuery
{
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
