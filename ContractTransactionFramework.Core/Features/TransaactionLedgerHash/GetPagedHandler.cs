using ContractTransactionFramework.Features.TransactionLedgerHash;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Core.Features.TransactionLedgerHash;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.TransactionLedgerHash>>
{
    public Task<IPagedResult<Models.TransactionLedgerHash>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
