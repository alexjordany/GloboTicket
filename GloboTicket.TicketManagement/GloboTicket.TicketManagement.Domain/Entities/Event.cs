namespace GloboTicket.TicketManagement.Domain.Entities;

public class Event : AuditableEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public String Artist { get; set; }
    public DateOnly Date { get; set; }
    public string? Description { get; set; }
    public string ImageURL { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }



}
