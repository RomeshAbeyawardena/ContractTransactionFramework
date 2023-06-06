using ContractTransactionFramework.Features.Contract;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Features.Contract;

public record Get : IRequest<IEnumerable<Models.Contract>>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
