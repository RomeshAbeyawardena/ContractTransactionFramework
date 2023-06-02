using ContractTransactionFramework.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Transaction;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.Transaction>>
{
    public Task<IEnumerable<Models.Transaction>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
