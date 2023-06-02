using ContractTransactionFramework.Persistence.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Contract;

public class PostHandler : IRequestHandler<Post, Models.Contract>
{
    public Task<Models.Contract> Handle(Post request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
