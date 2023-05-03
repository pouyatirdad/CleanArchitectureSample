using Clean.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain.Entities
{
    public class TodoList:BaseEntity
    {
        public string? Title { get; set; }
        public IList<TodoItem> Items { get; set; } = new List<TodoItem>();
    }
}
