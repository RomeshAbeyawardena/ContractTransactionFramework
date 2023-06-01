using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record Post : IRequest<Models.Signature>
{
    
}
