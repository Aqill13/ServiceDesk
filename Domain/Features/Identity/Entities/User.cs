using Domain.Common.Entities;

namespace ServiceDesk.Domain.Features.Identity.Entities;

public class User : BaseEntity
{
    public string KeycloakSubjectId { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string FirstName { get; private set; } = null!;
    public string LastName { get; private set; } = null!;
    public bool IsActive { get; private set; } = true;

    private User() { }

    public User(string keycloakSubjectId, string email, string firstName, string lastName)
    {
        KeycloakSubjectId = keycloakSubjectId;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
    }

    public void UpdateProfile( string email, string firstName, string lastName)
    {
        Email = email;
        FirstName = firstName;
        LastName = lastName;
    }

    public void Deactivate() => IsActive = false;
}