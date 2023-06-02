using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class PostHandler : IRequestHandler<Post, Models.Transaction>
{
    public Task<Models.Transaction> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
