﻿using Clean.Domain.Aggregate.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.TodoLists.Queries
{

    public record GetTodoListsQuery:IRequest<List<TodoList>>
    {

    }
}
