using Clean.Application.TodoItems.Commands;
using Clean.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.TodoItems.Handlers
{
    public class CreateTodoListHandler : IRequestHandler<CreateTodoListCommand>
    {
        private readonly AppDbContext _context;

        public CreateTodoListHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateTodoListCommand request, CancellationToken cancellationToken)
        {

            _context.TodoItems.Add(request.todoitem);
            return;
        }
    }
}
