using ContractTransactionFramework.Persistence.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public class GetHandler : IRequestHandler<Get, IEnumerable<Models.TransactionLedger>>
{
    public Task<IEnumerable<Models.TransactionLedger>> Handle(Get request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
