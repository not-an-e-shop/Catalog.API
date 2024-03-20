using Catalog.API.Domain.Events;
using Microsoft.Extensions.Logging;

namespace Catalog.API.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Catalog.API Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
