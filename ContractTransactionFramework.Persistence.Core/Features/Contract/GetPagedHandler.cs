using ContractTransactionFramework.Persistence.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Contract;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.Contract>>
{
    public Task<IEnumerable<Models.Contract>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
