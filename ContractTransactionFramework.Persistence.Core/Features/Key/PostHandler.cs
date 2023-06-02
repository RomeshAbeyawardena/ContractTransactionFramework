using ContractTransactionFramework.Persistence.Features.Key;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class PostHandler : IRequestHandler<Post, Models.Key>
{
    public Task<Models.Key> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
