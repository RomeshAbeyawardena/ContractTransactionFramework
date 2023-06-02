using ContractTransactionFramework.Persistence.Features.Key;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.Key>>
{
    public Task<IPagedResult<Models.Key>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
