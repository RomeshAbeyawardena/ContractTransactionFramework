using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Signature;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public class PutHandler : RepositoryHandlerBase<Put, Models.Signature, Models.Signature>
{
    [Inject] public IMapper? Mapper { get; set; }

    public PutHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Signature> Handle(Put request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Signature>, cancellationToken);
    }
}
