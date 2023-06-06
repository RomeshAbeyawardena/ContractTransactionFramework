using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Contract;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Contract;

public class PostHandler : RepositoryHandlerBase<Post, Models.Contract, Models.Contract>
{
    [Inject] public IMapper? Mapper { get; set; }
    public PostHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Contract> Handle(Post request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Contract>, cancellationToken);
    }
}
