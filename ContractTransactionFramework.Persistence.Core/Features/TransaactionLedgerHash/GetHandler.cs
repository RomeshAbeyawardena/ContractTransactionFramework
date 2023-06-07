using ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedgerHash;

public class GetHandler : RepositoryHandlerBase<Get, IEnumerable<Models.TransactionLedgerHash>,
    Models.TransactionLedgerHash>
{
    public GetHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.TransactionLedgerHash>> Handle(Get request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return ProcessQuery(builder.Filter(request), request, cancellationToken);
    }
}
