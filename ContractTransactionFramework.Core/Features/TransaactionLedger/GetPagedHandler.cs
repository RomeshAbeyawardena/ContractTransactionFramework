using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Core.Features.TransactionLedger;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.TransactionLedger>>
{
    public Task<IEnumerable<Models.TransactionLedger>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
