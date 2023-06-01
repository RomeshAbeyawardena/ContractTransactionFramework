using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedger;

public record Post : IRequest<Models.TransactionLedger>
{
    
}
