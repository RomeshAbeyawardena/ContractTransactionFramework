using AutoMapper;
using ContractTransactionFramework.Persistence.Features.ContractSignature;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.ContractSignature;

public class PostHandler : RepositoryHandlerBase<Post, Models.ContractSignature, Models.ContractSignature>
{
    [Inject] public IMapper? Mapper { get; set; }
    public PostHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.ContractSignature> Handle(Post request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.ContractSignature>, cancellationToken);
    }
}

