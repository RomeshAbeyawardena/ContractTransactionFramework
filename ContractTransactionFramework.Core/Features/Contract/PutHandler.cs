using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Contract;

public class PutHandler : IRequestHandler<Put, Models.Contract>
{
    public Task<Models.Contract> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
