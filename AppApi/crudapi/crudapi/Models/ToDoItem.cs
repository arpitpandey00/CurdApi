using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApi.Models
{
    public class ToDoItem
    {
        public long Id { get; set; }
        public string name { get; set; }
        public bool IsComplete { get; set; }
    }
}
