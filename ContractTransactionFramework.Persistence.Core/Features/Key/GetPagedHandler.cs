using ContractTransactionFramework.Persistence.Features.Key;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.Key>>
{
    public Task<IEnumerable<Models.Key>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
