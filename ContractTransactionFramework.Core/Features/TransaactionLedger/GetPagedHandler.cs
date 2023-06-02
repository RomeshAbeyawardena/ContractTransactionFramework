using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Core.Features.TransactionLedger;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.TransactionLedger>>
{
    public Task<IPagedResult<Models.TransactionLedger>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
