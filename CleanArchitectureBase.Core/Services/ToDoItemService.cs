using Ardalis.GuardClauses;
using CleanArchitectureBase.Core.Events;
using CleanArchitectureBase.Core.Interfaces;

namespace CleanArchitectureBase.Core.Services
{
    public class ToDoItemService : IHandler<ToDoItemCompletedEvent>
    {
        public void Handle(ToDoItemCompletedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // Do nothing
        }
    }
}
