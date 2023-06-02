using ContractTransactionFramework.Persistence.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.ContractSignature;

public class PutHandler : IRequestHandler<Put, Models.ContractSignature>
{
    public Task<Models.ContractSignature> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
