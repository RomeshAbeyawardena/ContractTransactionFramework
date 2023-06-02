using ContractTransactionFramework.Features.Intent;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Intent;

public class PostHandler : IRequestHandler<Post, Models.Intent>
{
    public Task<Models.Intent> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
