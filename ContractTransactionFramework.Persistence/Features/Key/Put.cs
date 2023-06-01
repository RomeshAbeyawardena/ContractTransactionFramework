using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Key;

public record Put : IRequest<Models.Key>
{

}
