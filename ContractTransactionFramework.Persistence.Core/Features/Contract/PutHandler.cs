using AutoMapper;
using ContractTransactionFramework.Persistence.Features.Contract;
using RST.DependencyInjection.Extensions.Attributes;
using RST.Mediatr.Extensions;

namespace ContractTransactionFramework.Persistence.Core.Features.Contract;

public class PutHandler : RepositoryHandlerBase<Put, Models.Contract, Models.Contract>
{
    [Inject] public IMapper? Mapper { get; set; }

    public PutHandler(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Contract> Handle(Put request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Contract>, cancellationToken);
    }
}
