using ContractTransactionFramework.Features.Contract;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Core.Features.Contract;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.Contract>>
{
    public Task<IPagedResult<Models.Contract>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
