using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Key;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class PutHandler : RepositoryHandlerBase<Put, Models.Key, Models.Key>
{
    [Inject] public IMapper? Mapper { get; set; }

    public PutHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Key> Handle(Put request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Key>, cancellationToken);
    }
}