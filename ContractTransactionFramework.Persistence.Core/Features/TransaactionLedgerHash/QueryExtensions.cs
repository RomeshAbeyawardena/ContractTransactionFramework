using ContractTransactionFramework.Features.TransactionLedgerHash;
using LinqKit;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedgerHash;

public static class QueryExtensions
{
    public static ExpressionStarter<Models.TransactionLedgerHash> Filter(this ExpressionStarter<Models.TransactionLedgerHash> expression, IQuery query)
    {
        return expression;
    }
}
