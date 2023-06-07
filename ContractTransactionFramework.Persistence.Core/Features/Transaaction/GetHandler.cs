using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class GetHandler : RepositoryHandlerBase<Get, IEnumerable<Models.Transaction>,
    Models.Transaction>
{
    public GetHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.Transaction>> Handle(Get request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return ProcessQuery(builder.Filter(request), request, cancellationToken);
    }
}
