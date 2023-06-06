using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Intent;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Intent;

public class PostHandler : RepositoryHandlerBase<Post, Models.Intent, Models.Intent>
{
    [Inject] public IMapper? Mapper { get; set; }
    public PostHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Intent> Handle(Post request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Intent>, cancellationToken);
    }
}
