using ContractTransactionFramework.Features.Transaction;
using RST.Contracts;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.Transaction;

public record GetPaged : IPagedRequest<Models.Transaction>, IQuery
{
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
