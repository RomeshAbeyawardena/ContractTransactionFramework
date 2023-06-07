using ContractTransactionFramework.Persistence.Features.Signature;
using MediatR;
using RST.Contracts;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public class GetHandler : RepositoryHandlerBase<Get, IEnumerable<Models.Signature>,
    Models.Signature>
{
    public GetHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.Signature>> Handle(Get request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return ProcessQuery(builder.Filter(request), request, cancellationToken);
    }
}