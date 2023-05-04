using Clean.Application.TodoItems.Queries;
using Clean.Domain.Entities;
using Clean.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.TodoItems.Handlers
{
    public class GetTodoItemsHandler : IRequestHandler<GetTodoListsQuery, List<TodoItem>>
    {
        private readonly AppDbContext _context;
        
        public GetTodoItemsHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoItem>> Handle(GetTodoListsQuery request, CancellationToken cancellationToken)
        {
            return _context.TodoItems.ToList();
        }
    }
}
