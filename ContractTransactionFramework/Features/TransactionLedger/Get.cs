using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Features.TransactionLedger;

public record Get : IRequest<IEnumerable<Models.TransactionLedger>>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
