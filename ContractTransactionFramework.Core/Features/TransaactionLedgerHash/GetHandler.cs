using ContractTransactionFramework.Features.TransactionLedgerHash;
using MediatR;

namespace ContractTransactionFramework.Core.Features.TransactionLedgerHash;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.TransactionLedgerHash>>
{
    public Task<IEnumerable<Models.TransactionLedgerHash>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
