using clean_architecture_grpc.Application.Common.Models;
using clean_architecture_grpc.Application.TodoItems.Commands.CreateTodoItem;
using clean_architecture_grpc.Application.TodoItems.Commands.DeleteTodoItem;
using clean_architecture_grpc.Application.TodoItems.Commands.UpdateTodoItem;
using clean_architecture_grpc.Application.TodoItems.Commands.UpdateTodoItemDetail;
using clean_architecture_grpc.Application.TodoItems.Queries.GetTodoItemsWithPagination;
using clean_architecture_grpc.Application.TodoLists.Queries.GetTodos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace clean_architecture_grpc.WebUI.Controllers
{
    [Authorize]
    public class TodoItemsController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetTodoItemsWithPagination([FromQuery] GetTodoItemsWithPaginationQuery query)
        {
            //Change to use IActionResult instead of PaginatedList<TodoItemDto>. Not as strong typed
            return Ok(await Mediator.Send(query));
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTodoItemCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateTodoItemCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult> UpdateItemDetails(int id, UpdateTodoItemDetailCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteTodoItemCommand { Id = id });

            return NoContent();
        }
    }
}
