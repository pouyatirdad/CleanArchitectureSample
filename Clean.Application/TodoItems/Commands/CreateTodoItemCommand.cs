using Clean.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.TodoItems.Commands
{
    public record CreateTodoListCommand(TodoItem todoitem) :IRequest
    {
    }
}
