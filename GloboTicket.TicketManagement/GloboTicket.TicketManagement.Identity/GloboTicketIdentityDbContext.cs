namespace GloboTicket.TicketManagement.Identity;

public class GloboTicketIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public GloboTicketIdentityDbContext(DbContextOptions<GloboTicketIdentityDbContext> options): base(options)
    {

    }
}
