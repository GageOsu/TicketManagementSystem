namespace TicketManagementSystem.Domain.Complaints;

public class ComplaintAssignee
{
    public Guid ComplaintId { get; private set; }
    public Guid UserId { get; private set; }

    public DateTime AcceptedDate { get; private set; }
    
    public Complaint Complaint { get; private set; }

    public ComplaintAssignee(Guid complaintId, Guid userId)
    {
        ComplaintId = complaintId;
        UserId = userId;
        AcceptedDate = DateTime.UtcNow;
    }
}