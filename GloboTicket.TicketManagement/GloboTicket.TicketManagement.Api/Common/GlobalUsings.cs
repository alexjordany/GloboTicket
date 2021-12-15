﻿global using Microsoft.AspNetCore.Mvc;
global using GloboTicket.TicketManagement.Application;
global using GloboTicket.TicketManagement.Infrastructure;
global using GloboTicket.TicketManagement.Persistence;
global using MediatR;
global using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
global using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesWithEvents;
global using GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCategory;
global using GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
global using GloboTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent;
global using GloboTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
global using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
global using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;
global using Microsoft.AspNetCore.Http;
global using System;
global using System.Collections.Generic;
global using System.Threading.Tasks;
global using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
global using Microsoft.OpenApi.Models;
global using Swashbuckle.AspNetCore.SwaggerGen;
global using GloboTicket.TicketManagement.Api.Utility;
global using GloboTicket.TicketManagement.Application.Features.Orders.Queries.GetOrdersForMonth;
