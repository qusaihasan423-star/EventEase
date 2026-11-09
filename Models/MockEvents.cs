namespace EventManagement.Models;

public static class MockEvents
{
    public static List<EventItem> Create() =>
    [
        new() { Id = 1, Name = "مؤتمر Blazor", Date = "15 ديسمبر 2026", Location = "عمّان" },
        new() { Id = 2, Name = "ورشة تصميم الواجهات", Date = "20 ديسمبر 2026", Location = "إربد" }
    ];
}
