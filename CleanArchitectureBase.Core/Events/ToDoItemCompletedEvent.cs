using CleanArchitectureBase.Core.Entities;
using CleanArchitectureBase.Core.SharedKernel;

namespace CleanArchitectureBase.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }

    }
}
