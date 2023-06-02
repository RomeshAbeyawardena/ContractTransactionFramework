using ContractTransactionFramework.Features.Transaction;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Core.Features.Transaction;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.Transaction>>
{
    public Task<IPagedResult<Models.Transaction>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
