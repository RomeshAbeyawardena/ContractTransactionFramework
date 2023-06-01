using ContractTransactionFramework.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Features.ContractSignature;

public record Get : IRequest<IEnumerable<Models.ContractSignature>>, IQuery
{
}
