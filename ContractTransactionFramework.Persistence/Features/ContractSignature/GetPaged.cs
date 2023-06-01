using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.ContractSignature;

public record GetPaged : IRequest<IEnumerable<Models.ContractSignature>>, IQuery
{
}
