using ContractTransactionFramework.Features.Intent;
using LinqKit;

namespace ContractTransactionFramework.Persistence.Core.Features.Intent;

public static class QueryExtensions
{
    public static ExpressionStarter<Models.Intent> Filter(this ExpressionStarter<Models.Intent> expression, IQuery query)
    {
        return expression;
    }
}
