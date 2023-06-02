using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Core.Features.TransactionLedger;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.TransactionLedger>>
{
    public Task<IEnumerable<Models.TransactionLedger>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
