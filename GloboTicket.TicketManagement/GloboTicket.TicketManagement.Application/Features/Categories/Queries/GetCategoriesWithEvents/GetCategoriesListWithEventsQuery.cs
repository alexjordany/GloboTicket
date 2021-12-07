namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesWithEvents;

public class GetCategoriesListWithEventsQuery : IRequest<List<CategoryEventListVm>>
{
    public bool IncludeHistory { get; set; }
}
