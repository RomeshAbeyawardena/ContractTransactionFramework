using ContractTransactionFramework.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.ContractSignature;

public record Get : IRequest<IEnumerable<Models.ContractSignature>>, IQuery
{
}
