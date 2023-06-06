using ContractTransactionFramework.Features.ContractSignature;
using MediatR;
using RST.Enumerations;

namespace ContractTransactionFramework.Features.ContractSignature;

public record Get : IRequest<IEnumerable<Models.ContractSignature>>, IQuery
{
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
