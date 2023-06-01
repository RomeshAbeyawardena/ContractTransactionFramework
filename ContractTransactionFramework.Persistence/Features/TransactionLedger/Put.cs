using MediatR;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedger;

public record Put : IRequest<Models.TransactionLedger>
{

}
