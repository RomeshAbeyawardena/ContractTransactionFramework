using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Intent;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Intent;

public class PutHandler : RepositoryHandlerBase<Put, Models.Intent, Models.Intent>
{
    [Inject] public IMapper? Mapper { get; set; }

    public PutHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Intent> Handle(Put request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Intent>, cancellationToken);
    }
}