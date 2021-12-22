namespace GloboTicket.TicketManagement.App.Profiles;

public class Mappings : Profile
{
    public Mappings()
    {
        CreateMap<EventListVm, EventListViewModel>().ReverseMap();
        CreateMap<EventDetailVm, EventDetailViewModel>().ReverseMap();

        CreateMap<EventDetailViewModel, CreateEventCommand>().ReverseMap();
        CreateMap<EventDetailViewModel, UpdateEventCommand>().ReverseMap();

        CreateMap<CategoryEventDto, EventNestedViewModel>().ReverseMap();

        CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();
        CreateMap<CategoryListVm, CategoryViewModel>().ReverseMap();
        CreateMap<CategoryEventListVm, CategoryEventsViewModel>().ReverseMap();
        CreateMap<CreateCategoryCommand, CategoryViewModel>().ReverseMap();
        CreateMap<CreateCategoryDto, CategoryDto>().ReverseMap();

        CreateMap<PagedOrdersForMonthVm, PagedOrderForMonthViewModel>().ReverseMap();
        CreateMap<OrdersForMonthDto, OrdersForMonthListViewModel>().ReverseMap();
    }
}
