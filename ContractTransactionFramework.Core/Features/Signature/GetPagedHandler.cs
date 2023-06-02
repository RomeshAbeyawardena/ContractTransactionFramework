using ContractTransactionFramework.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Signature;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.Signature>>
{
    public Task<IEnumerable<Models.Signature>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
