using ContractTransactionFramework.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Core.Features.ContractSignature;

public class PutHandler : IRequestHandler<Put, Models.ContractSignature>
{
    public Task<Models.ContractSignature> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
