using ContractTransactionFramework.Persistence.Features.Signature;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public class GetPagedHandler : PagedRepositoryHandlerBase<GetPaged, Models.Signature>
{
    public GetPagedHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IPagedResult<Models.Signature>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return base.ProcessPagedQuery(builder, request, cancellationToken);
    }
}

