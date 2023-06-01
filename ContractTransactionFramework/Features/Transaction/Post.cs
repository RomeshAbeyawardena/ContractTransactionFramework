using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Features.Transaction;

public record Post : IRequest<Models.Transaction>, ITransaction
{
    public Guid ContractId { get; set; }
    public string? Name { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
