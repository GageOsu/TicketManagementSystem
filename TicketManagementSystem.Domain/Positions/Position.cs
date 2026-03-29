using TicketManagementSystem.Domain.Users;

namespace TicketManagementSystem.Domain.Positions;

public class Position
{
    public Guid Id { get; private set; }
    public string PositionName { get; private set; }

    private readonly List<User> _users = new();
    public IReadOnlyCollection<User> Users => _users;

    public Position(string positionName)
    {
        PositionName = positionName;
    }
}