using ContractTransactionFramework.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Signature;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.Signature>>
{
    public Task<IEnumerable<Models.Signature>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
