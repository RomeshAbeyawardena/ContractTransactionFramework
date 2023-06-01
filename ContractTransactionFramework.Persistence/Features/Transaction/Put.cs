using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Transaction;

public record Put : IRequest<Models.Transaction>
{

}
