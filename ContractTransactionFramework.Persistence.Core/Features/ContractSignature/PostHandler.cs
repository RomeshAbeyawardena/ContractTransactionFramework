using ContractTransactionFramework.Persistence.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.ContractSignature;

public class PostHandler : IRequestHandler<Post, Models.ContractSignature>
{
    public Task<Models.ContractSignature> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
