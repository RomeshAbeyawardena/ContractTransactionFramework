using ContractTransactionFramework.Features.TransactionLedgerHash;
using MediatR;

namespace ContractTransactionFramework.Core.Features.TransactionLedgerHash;

public class PostHandler : IRequestHandler<Post, Models.TransactionLedgerHash>
{
    public Task<Models.TransactionLedgerHash> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
