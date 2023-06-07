using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class PutHandler : RepositoryHandlerBase<Put, Models.Transaction, Models.Transaction>
{
    [Inject] public IMapper? Mapper { get; set; }

    public PutHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Transaction> Handle(Put request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Transaction>, cancellationToken);
    }
}