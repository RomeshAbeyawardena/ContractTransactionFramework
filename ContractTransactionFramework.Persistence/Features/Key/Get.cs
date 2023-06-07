using ContractTransactionFramework.Features.Key;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.Key;

public record Get : IRequest<IEnumerable<Models.Key>>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
