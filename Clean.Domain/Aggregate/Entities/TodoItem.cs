using Clean.Domain.Aggregate.Enum;
using Clean.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain.Aggregate.Entities
{
    public class TodoItem : BaseEntity
    {
        public string? Title { get; set; }
        public string? Desc { get; set; }
        public bool Done { get; set; } = false;
        public PriorityLevel PriorityLevel { get; set; } = PriorityLevel.medium;
        public int ListId { get; set; }
        public TodoList List { get; set; }
    }
}
