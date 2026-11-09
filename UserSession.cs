namespace EventManagement.Services;

public class UserSession
{
    public string? UserName { get; private set; }
    public List<int> AttendingEventIds { get; } = new();

    public bool IsRegistered => !string.IsNullOrEmpty(UserName);

    public event Action? OnChange;

    public void Register(string name)
    {
        UserName = name;
        OnChange?.Invoke();
    }

    public void Attend(int eventId)
    {
        if (!AttendingEventIds.Contains(eventId))
        {
            AttendingEventIds.Add(eventId);
            OnChange?.Invoke();
        }
    }
}