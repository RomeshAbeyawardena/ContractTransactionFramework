using Microsoft.EntityFrameworkCore;

namespace ContractTransactionFramework.Persistence.SqlServer;

public sealed class ContractTransactionFrameworkContext : DbContext
{
    public ContractTransactionFrameworkContext(DbContextOptions<ContractTransactionFrameworkContext> options)
        : base(options)
    {
        
    }

    public DbSet<Models.Contract> Contracts { get; set; }
    public DbSet<Models.ContractSignature> ContractSignatures { get; set; }
    public DbSet<Models.Intent> Intents { get; set; }
    public DbSet<Models.Key> Keys { get; set; }
    public DbSet<Models.Signature> Signatures { get; set; }
    public DbSet<Models.Transaction> Transactions { get; set; }
    public DbSet<Models.TransactionLedger> TransactionLedgers { get; set; }
    public DbSet<Models.TransactionLedgerHash> TransactionLedgerHashes { get; set; } 
}
