using ContractTransactionFramework.Features.Contract;
using RST.Contracts;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.Contract;

public record GetPaged : IPagedRequest<Models.Contract>, IQuery
{
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
