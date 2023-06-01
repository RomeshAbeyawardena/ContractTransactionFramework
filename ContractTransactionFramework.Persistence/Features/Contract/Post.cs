using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Contract;

public record Post : IRequest<Models.Contract>
{
    
}
