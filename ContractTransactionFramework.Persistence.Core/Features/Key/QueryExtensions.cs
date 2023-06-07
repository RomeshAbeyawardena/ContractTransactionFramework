using ContractTransactionFramework.Features.Key;
using LinqKit;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public static class QueryExtensions
{
    public static ExpressionStarter<Models.Key> Filter(this ExpressionStarter<Models.Key> expression, IQuery query)
    {
        return expression;
    }
}
