using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Transaction;

public record Put : IRequest<Models.Transaction>, ITransaction
{
    public Guid ContractId { get; set; }
    public string? Name { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
