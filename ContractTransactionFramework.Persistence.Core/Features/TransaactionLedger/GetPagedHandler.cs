using ContractTransactionFramework.Persistence.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.TransactionLedger>>
{
    public Task<IEnumerable<Models.TransactionLedger>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
