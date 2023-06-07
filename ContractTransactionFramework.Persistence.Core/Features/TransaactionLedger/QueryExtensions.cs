using ContractTransactionFramework.Features.TransactionLedger;
using LinqKit;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public static class QueryExtensions
{
    public static ExpressionStarter<Models.TransactionLedger> Filter(this ExpressionStarter<Models.TransactionLedger> expression, IQuery query)
    {
        return expression;
    }
}
