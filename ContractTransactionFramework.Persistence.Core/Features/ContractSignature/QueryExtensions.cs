using ContractTransactionFramework.Features.ContractSignature;
using LinqKit;

namespace ContractTransactionFramework.Persistence.Core.Features.ContractSignature;

public static class QueryExtensions
{
    public static ExpressionStarter<Models.ContractSignature> Filter(this ExpressionStarter<Models.ContractSignature> expression, IQuery query)
    {
        return expression;
    }
}
