using ContractTransactionFramework.Persistence.Features.TransactionLedger;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public class GetPagedHandler : PagedRepositoryHandlerBase<GetPaged, Models.TransactionLedger>
{
    public GetPagedHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IPagedResult<Models.TransactionLedger>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return base.ProcessPagedQuery(builder, request, cancellationToken);
    }
}

