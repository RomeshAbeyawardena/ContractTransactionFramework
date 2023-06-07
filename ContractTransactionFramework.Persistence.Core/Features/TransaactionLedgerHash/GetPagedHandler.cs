using ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedgerHash;

public class GetPagedHandler : PagedRepositoryHandlerBase<GetPaged, Models.TransactionLedgerHash>
{
    public GetPagedHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IPagedResult<Models.TransactionLedgerHash>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return base.ProcessPagedQuery(builder, request, cancellationToken);
    }
}