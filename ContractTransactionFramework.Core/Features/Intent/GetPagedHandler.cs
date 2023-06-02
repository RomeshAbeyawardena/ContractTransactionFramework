using ContractTransactionFramework.Features.Intent;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Intent;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.Intent>>
{
    public Task<IEnumerable<Models.Intent>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
