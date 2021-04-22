using clean_architecture_grpc.Application.Common.Mappings;
using clean_architecture_grpc.Domain.Entities;

namespace clean_architecture_grpc.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
