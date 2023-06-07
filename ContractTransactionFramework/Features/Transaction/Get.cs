using ContractTransactionFramework.Features.Transaction;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Features.Transaction;

public record Get : IRequest<IEnumerable<Models.Transaction>>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
