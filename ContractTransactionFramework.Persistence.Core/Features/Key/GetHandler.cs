using ContractTransactionFramework.Persistence.Features.Key;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.Key>>
{
    public Task<IEnumerable<Models.Key>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
