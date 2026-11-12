using EarnPro.Domain.Common;
using EarnPro.Domain.Enums;

namespace EarnPro.Domain.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public UserRole Role { get; set; } = UserRole.User;

    public bool IsActive { get; set; } = true;
}
