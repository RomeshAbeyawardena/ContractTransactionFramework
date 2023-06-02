using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.Transaction>>
{
    public Task<IEnumerable<Models.Transaction>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
