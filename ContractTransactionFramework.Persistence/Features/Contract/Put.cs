using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Contract;

public record Put : IRequest<Models.Contract>, IContract
{
    public Guid? TransactionId { get; set; }
    public Guid? ContractId { get; set; }
    public string? Name { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
