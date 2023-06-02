using ContractTransactionFramework.Persistence.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public class PostHandler : IRequestHandler<Post, Models.Signature>
{
    public Task<Models.Signature> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
