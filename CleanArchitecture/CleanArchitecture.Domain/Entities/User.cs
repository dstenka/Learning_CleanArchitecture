using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = default!;
    public string Name { get; set; } = default!;
}
