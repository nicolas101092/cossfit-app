namespace CrossfitApp.Shared.Authentication;

public sealed class UserInfo
{
    public required string UserId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Picture { get; set; }
    public string? Role { get; set; }
}
