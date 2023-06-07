using AutoMapper;
using ContractTransactionFramework.Persistence.Features.TransactionLedger;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public class PostHandler : RepositoryHandlerBase<Post, Models.TransactionLedger, Models.TransactionLedger>
{
    [Inject] public IMapper? Mapper { get; set; }
    public PostHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.TransactionLedger> Handle(Post request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.TransactionLedger>, cancellationToken);
    }
}
