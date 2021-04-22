using clean_architecture_grpc.Domain.Common;
using clean_architecture_grpc.Domain.Entities;

namespace clean_architecture_grpc.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
