using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Intent;

public record Put : IRequest<Models.Intent>
{

}
