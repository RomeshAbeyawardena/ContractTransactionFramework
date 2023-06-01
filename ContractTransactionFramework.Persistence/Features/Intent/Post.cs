using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Intent;

public record Post : IRequest<Models.Intent>
{
    
}
