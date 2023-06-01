using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Transaction;

public record Post : IRequest<Models.Transaction>
{
    
}
