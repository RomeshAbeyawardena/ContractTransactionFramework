using ContractTransactionFramework.Features.ContractSignature;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Core.Features.ContractSignature;

public class GetPagedHandler : IRequestHandler<GetPaged, IPagedResult<Models.ContractSignature>>
{
    public Task<IPagedResult<Models.ContractSignature>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
