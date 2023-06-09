﻿using Clean.Application.TodoLists.Commands;
using Clean.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.TodoLists.Handlers
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

            _context.TodoLists.Add(request.todoList);
            return;
        }
    }
}
