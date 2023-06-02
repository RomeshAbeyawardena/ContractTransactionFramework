using ContractTransactionFramework.Features.ContractSignature;
using RST.Contracts;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.ContractSignature;

public record GetPaged : IPagedRequest<Models.ContractSignature>, IQuery
{
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
