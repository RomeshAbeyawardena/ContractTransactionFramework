using RST.Contracts;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Features.Transaction;

public record GetPaged : IPagedRequest<Models.Transaction>, IQuery
{
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
