using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class PostHandler : RepositoryHandlerBase<Post, Models.Transaction, Models.Transaction>
{
    [Inject] public IMapper? Mapper { get; set; }
    public PostHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Transaction> Handle(Post request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Transaction>, cancellationToken);
    }
}