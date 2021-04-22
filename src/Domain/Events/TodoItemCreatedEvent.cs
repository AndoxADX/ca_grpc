using clean_architecture_grpc.Domain.Common;
using clean_architecture_grpc.Domain.Entities;

namespace clean_architecture_grpc.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
