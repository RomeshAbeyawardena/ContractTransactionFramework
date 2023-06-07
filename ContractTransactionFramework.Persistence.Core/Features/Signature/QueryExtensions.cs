using LinqKit;
using ContractTransactionFramework.Features.Signature;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public static class QueryExtensions
{
    public static ExpressionStarter<Models.Signature> Filter(this ExpressionStarter<Models.Signature> expression, IQuery query)
    {
        return expression;
    }
}
