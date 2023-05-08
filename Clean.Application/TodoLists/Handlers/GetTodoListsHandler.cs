using Clean.Application.TodoLists.Queries;
using Clean.Domain.Aggregate.Entities;
using Clean.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.TodoLists.Handlers
{
    public class GetTodoListsHandler : IRequestHandler<GetTodoListsQuery, List<TodoList>>
    {
        private readonly AppDbContext _context;
        
        public GetTodoListsHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoList>> Handle(GetTodoListsQuery request, CancellationToken cancellationToken)
        {
            return _context.TodoLists.Include(x=>x.Items).ToList();
        }
    }
}
