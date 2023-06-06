using ContractTransactionFramework.Persistence.Features.ContractSignature;
using MediatR;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.ContractSignature;

public class GetHandler : RepositoryHandlerBase<Get, IEnumerable<Models.ContractSignature>,
    Models.ContractSignature>
{
    public GetHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.ContractSignature>> Handle(Get request, CancellationToken cancellationToken)
    {
        var builder = Repository!.QueryBuilder;
        return ProcessQuery(builder.Filter(request), request, cancellationToken);
    }
}
