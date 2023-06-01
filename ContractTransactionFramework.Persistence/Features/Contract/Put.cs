using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Contract;

public record Put : IRequest<Models.Contract>
{

}
