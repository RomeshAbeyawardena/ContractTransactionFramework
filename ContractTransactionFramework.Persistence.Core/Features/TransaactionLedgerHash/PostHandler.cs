using AutoMapper;
using ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedgerHash;

public class PostHandler : RepositoryHandlerBase<Post, Models.TransactionLedgerHash, Models.TransactionLedgerHash>
{
    [Inject] public IMapper? Mapper { get; set; }
    public PostHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.TransactionLedgerHash> Handle(Post request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.TransactionLedgerHash>, cancellationToken);
    }
}