﻿namespace ContractTransactionFramework.Models;

public record TransactionLedgerHash : ITransactionLedgerHash
{
    public Guid TransactionLedgerId { get; set; }
    public string? DataHash { get; set; }
    public bool IsViable { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
