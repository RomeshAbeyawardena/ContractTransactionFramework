using ContractTransactionFramework.Features.Signature;
using RST.Contracts;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record GetPaged : IPagedRequest<Models.Signature>, IQuery
{
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
