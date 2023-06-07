using ContractTransactionFramework.Features.Signature;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record Get : IRequest<IEnumerable<Models.Signature>>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
