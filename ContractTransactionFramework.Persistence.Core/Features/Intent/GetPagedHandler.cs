using ContractTransactionFramework.Persistence.Features.Intent;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Core.Features.Intent;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.Intent>>
{
    public Task<IPagedResult<Models.Intent>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
