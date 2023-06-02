using ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedgerHash;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.TransactionLedgerHash>>
{
    public Task<IEnumerable<Models.TransactionLedgerHash>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
