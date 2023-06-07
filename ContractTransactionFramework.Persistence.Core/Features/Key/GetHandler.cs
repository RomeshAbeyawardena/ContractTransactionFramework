using ContractTransactionFramework.Persistence.Features.Key;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class GetHandler : RepositoryHandlerBase<Get, IEnumerable<Models.Key>,
    Models.Key>
{
    public GetHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.Key>> Handle(Get request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return ProcessQuery(builder.Filter(request), request, cancellationToken);
    }
}
