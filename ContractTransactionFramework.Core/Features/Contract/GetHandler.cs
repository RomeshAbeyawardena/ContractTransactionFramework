using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Contract;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.Contract>>
{
    public Task<IEnumerable<Models.Contract>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
