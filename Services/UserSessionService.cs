using EventEase.Models;
public class UserSessionService
{
    public Dictionary<int, RegistrationModel> Registrations { get; } = new();

    public void Register(int eventId, RegistrationModel registration)
    {
        Registrations[eventId] = registration;
    }

    public bool IsRegistered(int eventId) => Registrations.ContainsKey(eventId);
}
