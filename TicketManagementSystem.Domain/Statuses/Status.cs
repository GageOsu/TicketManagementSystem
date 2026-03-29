using TicketManagementSystem.Domain.Complaints;

namespace TicketManagementSystem.Domain.Statuses;

public class Status
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }

    private readonly List<Complaint> _complaints = new();
    public IReadOnlyCollection<Complaint> Complaints => _complaints;

    public Status(string name)
    {
        Name = name;
    }
}