using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;

public record Post : IRequest<Models.TransactionLedgerHash>
{
    
}
