using ContractTransactionFramework.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Core.Features.ContractSignature;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.ContractSignature>>
{
    public Task<IEnumerable<Models.ContractSignature>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
