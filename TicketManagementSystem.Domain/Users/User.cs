using TicketManagementSystem.Domain.Complaints;

namespace TicketManagementSystem.Domain.Users;

public class User
{
    public Guid Id { get; private set; }

    public Guid PositionId { get; private set; }

    public string FirstName { get; private set; }
    public string? LastName { get; private set; }
    
    public string PhoneNumber { get; private set; }

    private readonly List<Complaint> _createdComplaints = new();
    public IReadOnlyCollection<Complaint> CreatedComplaints => _createdComplaints;

    private readonly List<ComplaintAssignee> _assignedComplaints = new();
    public IReadOnlyCollection<ComplaintAssignee> AssignedComplaints => _assignedComplaints;

    public User(Guid positionId, string firstName, string phoneNumber)
    {
        PositionId = positionId;
        FirstName = firstName;
        PhoneNumber = phoneNumber;
    }
}