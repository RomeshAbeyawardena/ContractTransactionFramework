using LinqKit;
using ContractTransactionFramework.Features.Contract;
namespace ContractTransactionFramework.Persistence.Core.Features.Contract;

public static class QueryExtensions
{
    public static ExpressionStarter<Models.Contract> Filter(this ExpressionStarter<Models.Contract> expression, IQuery query)
    {
        return expression;
    }
}
