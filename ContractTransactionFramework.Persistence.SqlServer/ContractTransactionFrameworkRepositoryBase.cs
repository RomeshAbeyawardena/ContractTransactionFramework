using LinqKit;
using RST.EntityFrameworkCore;
using System.Reactive.Subjects;

namespace ContractTransactionFramework.Persistence.SqlServer;

public abstract class ContractTransactionFrameworkRepositoryBase<T> : EntityFrameworkRepositoryBase<ContractTransactionFrameworkContext, T>
    where T: class
{
    protected ContractTransactionFrameworkRepositoryBase(
        ContractTransactionFrameworkContext context, ISubject<ExpressionStarter<T>> subject) : base(context, subject)
    {
    }
}
