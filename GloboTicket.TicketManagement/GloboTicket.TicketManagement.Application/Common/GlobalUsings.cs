﻿global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using GloboTicket.TicketManagement.Domain.Entities;
global using MediatR;
global using GloboTicket.TicketManagement.Application.Contracts.Persistence;
global using AutoMapper;
global using GloboTicket.TicketManagement.Application.Features.Events;
global using Microsoft.Extensions.DependencyInjection;
global using System.Reflection;
global using FluentValidation;
global using FluentValidation.Results;
global using GloboTicket.TicketManagement.Application.Responses;
global using GloboTicket.TicketManagement.Application.Models.Mail;
global using GloboTicket.TicketManagement.Application.Contracts.Infrastructure;
global using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
global using GloboTicket.TicketManagement.Application.Exceptions;
global using Microsoft.Extensions.Logging;
global using GloboTicket.TicketManagement.Application.Models.Authentication;
global using System.ComponentModel.DataAnnotations;

