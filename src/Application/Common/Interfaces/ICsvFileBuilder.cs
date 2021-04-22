using clean_architecture_grpc.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace clean_architecture_grpc.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
