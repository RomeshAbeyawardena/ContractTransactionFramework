using ContractTransactionFramework.Features.Key;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Key;

public class PostHandler : IRequestHandler<Post, Models.Key>
{
    public Task<Models.Key> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
