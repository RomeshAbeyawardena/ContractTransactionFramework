using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Contract;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.Contract>>
{
    public Task<IEnumerable<Models.Contract>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
