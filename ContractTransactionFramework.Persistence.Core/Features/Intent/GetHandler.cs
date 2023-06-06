using ContractTransactionFramework.Persistence.Features.Intent;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Intent;

public class GetHandler : RepositoryHandlerBase<Get, IEnumerable<Models.Intent>,
    Models.Intent>
{
    public GetHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.Intent>> Handle(Get request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return ProcessQuery(builder.Filter(request), request, cancellationToken);
    }
}
