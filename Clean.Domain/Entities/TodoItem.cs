using Clean.Domain.Common;
using Clean.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain.Entities
{
    public class TodoItem:BaseEntity
    {
        public string? Title { get; set; }
        public string? Desc { get; set; }
        public bool Done { get; set; } = false;
        public PriorityLevel PriorityLevel { get; set; } = PriorityLevel.medium;
        public int ListId { get; set; }
        public TodoList List { get; set; }
    }
}
