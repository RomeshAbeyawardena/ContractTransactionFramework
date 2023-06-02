using ContractTransactionFramework.Features.TransactionLedger;
using RST.Contracts;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedger;

public record GetPaged : IPagedRequest<Models.TransactionLedger>, IQuery
{
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
