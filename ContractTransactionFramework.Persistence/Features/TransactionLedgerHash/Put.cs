using MediatR;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;

public record Put : IRequest<Models.TransactionLedgerHash>
{

}
