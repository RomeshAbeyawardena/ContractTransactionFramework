using ContractTransactionFramework.Features.Intent;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Intent;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.Intent>>
{
    public Task<IEnumerable<Models.Intent>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
