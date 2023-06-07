using ContractTransactionFramework.Features.Transaction;
using LinqKit;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public static class QueryExtensions
{
    public static ExpressionStarter<Models.Transaction> Filter(this ExpressionStarter<Models.Transaction> expression, IQuery query)
    {
        return expression;
    }
}
