using RST.Contracts;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Features.TransactionLedgerHash;

public record GetPaged : IPagedRequest<Models.TransactionLedgerHash>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
}
