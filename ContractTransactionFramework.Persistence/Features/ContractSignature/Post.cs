using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.ContractSignature;

public record Post : IRequest<Models.ContractSignature>
{
    
}
