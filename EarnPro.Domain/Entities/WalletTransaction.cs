using EarnPro.Domain.Common;
using EarnPro.Domain.Enums;

namespace EarnPro.Domain.Entities;

public class WalletTransaction : BaseEntity
{
    public int UserId { get; set; }

    public decimal Amount { get; set; }

    public TransactionType Type { get; set; }

    public TransactionStatus Status { get; set; } = TransactionStatus.Pending;

    public string Description { get; set; } = string.Empty;

    public bool IsDemoOnly { get; set; } = true;
}
