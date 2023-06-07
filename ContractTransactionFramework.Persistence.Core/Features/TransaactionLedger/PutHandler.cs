using AutoMapper;
using ContractTransactionFramework.Persistence.Features.TransactionLedger;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public class PutHandler : RepositoryHandlerBase<Put, Models.TransactionLedger, Models.TransactionLedger>
{
    [Inject] public IMapper? Mapper { get; set; }

    public PutHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.TransactionLedger> Handle(Put request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.TransactionLedger>, cancellationToken);
    }
}