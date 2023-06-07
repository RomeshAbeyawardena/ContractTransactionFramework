using ContractTransactionFramework.Persistence.Features.Key;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class GetPagedHandler : PagedRepositoryHandlerBase<GetPaged, Models.Key>
{
    public GetPagedHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IPagedResult<Models.Key>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return base.ProcessPagedQuery(builder, request, cancellationToken);
    }
}
