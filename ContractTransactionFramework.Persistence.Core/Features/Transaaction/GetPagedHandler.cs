using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class GetPagedHandler : PagedRepositoryHandlerBase<GetPaged, Models.Transaction>
{
    public GetPagedHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IPagedResult<Models.Transaction>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return base.ProcessPagedQuery(builder, request, cancellationToken);
    }
}
