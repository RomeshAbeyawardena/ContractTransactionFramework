using AutoMapper;
using ContractTransactionFramework.Persistence.Features.ContractSignature;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.ContractSignature;

public class PutHandler : RepositoryHandlerBase<Put, Models.ContractSignature, Models.ContractSignature>
{
    [Inject] public IMapper? Mapper { get; set; }

    public PutHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.ContractSignature> Handle(Put request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.ContractSignature>, cancellationToken);
    }
}
