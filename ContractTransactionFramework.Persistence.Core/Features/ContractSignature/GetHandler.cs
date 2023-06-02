using ContractTransactionFramework.Persistence.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.ContractSignature;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.ContractSignature>>
{
    public Task<IEnumerable<Models.ContractSignature>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
