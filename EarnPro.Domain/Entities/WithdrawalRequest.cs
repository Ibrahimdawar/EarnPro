using EarnPro.Domain.Common;
using EarnPro.Domain.Enums;

namespace EarnPro.Domain.Entities;

public class WithdrawalRequest : BaseEntity
{
    public int UserId { get; set; }

    public decimal Amount { get; set; }

    public WithdrawalStatus Status { get; set; } = WithdrawalStatus.Pending;

    public string Reason { get; set; } = string.Empty;

    public bool IsDemoOnly { get; set; } = true;
}
