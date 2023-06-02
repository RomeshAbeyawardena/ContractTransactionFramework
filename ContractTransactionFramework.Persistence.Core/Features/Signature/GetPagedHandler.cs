using ContractTransactionFramework.Persistence.Features.Signature;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.Signature>>
{
    public Task<IPagedResult<Models.Signature>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
