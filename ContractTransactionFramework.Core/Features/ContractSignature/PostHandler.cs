using ContractTransactionFramework.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Core.Features.ContractSignature;

public class PostHandler : IRequestHandler<Post, Models.ContractSignature>
{
    public Task<Models.ContractSignature> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
