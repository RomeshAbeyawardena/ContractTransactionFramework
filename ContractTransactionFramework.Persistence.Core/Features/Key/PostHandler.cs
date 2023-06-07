using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Key;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class PostHandler : RepositoryHandlerBase<Post, Models.Key, Models.Key>
{
    [Inject] public IMapper? Mapper { get; set; }
    public PostHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Key> Handle(Post request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Key>, cancellationToken);
    }
}
