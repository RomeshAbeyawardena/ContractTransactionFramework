using ContractTransactionFramework.Persistence.Features.Contract;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Contract;

public class GetHandler : RepositoryHandlerBase<Get, IEnumerable<Models.Contract>, Models.Contract>
{
    public GetHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.Contract>> Handle(Get request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return ProcessQuery(builder.Filter(request), request, cancellationToken);
    }
}
