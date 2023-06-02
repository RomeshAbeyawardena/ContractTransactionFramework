using RST.Contracts;
using RST.Enumerations;

namespace ContractTransactionFramework.Features.TransactionLedger;

public record GetPaged : IPagedRequest<Models.TransactionLedger>, IQuery
{
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
