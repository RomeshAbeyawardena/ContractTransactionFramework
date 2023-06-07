using ContractTransactionFramework.Persistence.Features.TransactionLedger;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public class GetHandler : RepositoryHandlerBase<Get, IEnumerable<Models.TransactionLedger>,
    Models.TransactionLedger>
{
    public GetHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.TransactionLedger>> Handle(Get request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return ProcessQuery(builder.Filter(request), request, cancellationToken);
    }
}
