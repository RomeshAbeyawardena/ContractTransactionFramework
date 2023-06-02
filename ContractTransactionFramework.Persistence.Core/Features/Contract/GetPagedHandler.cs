using ContractTransactionFramework.Persistence.Features.Contract;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Core.Features.Contract;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.Contract>>
{
    public Task<IPagedResult<Models.Contract>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
