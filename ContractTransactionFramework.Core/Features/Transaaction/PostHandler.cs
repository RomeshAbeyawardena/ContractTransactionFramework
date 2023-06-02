using ContractTransactionFramework.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Transaction;

public class PostHandler : IRequestHandler<Post, Models.Transaction>
{
    public Task<Models.Transaction> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
