using ContractTransactionFramework.Features.Intent;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Persistence.Features.Intent;

public record Get : IRequest<IEnumerable<Models.Intent>>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
