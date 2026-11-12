using EarnPro.Domain.Common;

namespace EarnPro.Domain.Entities;

public class TaskItem : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal RewardAmount { get; set; }

    public int? AssignedUserId { get; set; }

    public bool IsCompleted { get; set; }
}
