using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Features.Intent;

public record Post : IRequest<Models.Intent>, IIntent
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsSuppresed { get; set; }
    public DateTimeOffset Created { get; set; }
}
