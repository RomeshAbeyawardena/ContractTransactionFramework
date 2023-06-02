using ContractTransactionFramework.Features.Intent;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Core.Features.Intent;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.Intent>>
{
    public Task<IPagedResult<Models.Intent>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
