using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.Transaction>>
{
    public Task<IPagedResult<Models.Transaction>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
