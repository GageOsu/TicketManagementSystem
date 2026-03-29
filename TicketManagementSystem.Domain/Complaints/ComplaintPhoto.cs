namespace TicketManagementSystem.Domain.Complaints;

public class ComplaintPhoto
{
    public Guid Id { get; private set; }
    public Guid ComplaintId { get; private set; }

    public byte[] Data { get; private set; }

    public ComplaintPhoto(Guid complaintId, byte[] data)
    {
        ComplaintId = complaintId;
        Data = data;
    }
}