namespace TicketManagementSystem.Domain.Complaints;

public class Complaint
{
    public Guid Id { get; private set; }

    public Guid CreatedById { get; private set; }
    public Guid StatusId { get; private set; }

    public DateTime CreateDate { get; private set; }
    public DateTime? CompletionDate { get; private set; }

    public string Description { get; private set; }

    private readonly List<ComplaintAssignee> _assignees = new();
    public IReadOnlyCollection<ComplaintAssignee> Assignees => _assignees;

    private readonly List<ComplaintPhoto> _photos = new();
    public IReadOnlyCollection<ComplaintPhoto> Photos => _photos;

    public Complaint(Guid createdById, Guid statusId, string description)
    {
        CreatedById = createdById;
        StatusId = statusId;
        Description = description;
        CreateDate = DateTime.UtcNow;
    }

    public void Complete()
    {
        CompletionDate = DateTime.UtcNow;
    }
}