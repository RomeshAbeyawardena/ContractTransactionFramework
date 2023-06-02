using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.Transaction>>
{
    public Task<IEnumerable<Models.Transaction>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
