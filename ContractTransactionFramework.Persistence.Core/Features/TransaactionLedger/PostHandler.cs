using ContractTransactionFramework.Persistence.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public class PostHandler : IRequestHandler<Post, Models.TransactionLedger>
{
    public Task<Models.TransactionLedger> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
