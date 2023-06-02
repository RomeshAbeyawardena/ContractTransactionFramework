using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Core.Features.TransactionLedger;

public class PostHandler : IRequestHandler<Post, Models.TransactionLedger>
{
    public Task<Models.TransactionLedger> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
