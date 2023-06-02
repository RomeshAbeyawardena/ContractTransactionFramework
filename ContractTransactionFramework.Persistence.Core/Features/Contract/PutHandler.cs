using ContractTransactionFramework.Persistence.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Contract;

public class PutHandler : IRequestHandler<Put, Models.Contract>
{
    public Task<Models.Contract> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
