using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Signature;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public class PostHandler : RepositoryHandlerBase<Post, Models.Signature, Models.Signature>
{
    [Inject] public IMapper? Mapper { get; set; }
    public PostHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Signature> Handle(Post request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Signature>, cancellationToken);
    }
}
