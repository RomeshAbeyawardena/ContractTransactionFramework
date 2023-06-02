using ContractTransactionFramework.Persistence.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.Signature>>
{
    public Task<IEnumerable<Models.Signature>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
