using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Key;

public record Post : IRequest<Models.Key>
{
    
}
