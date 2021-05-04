using AngularApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApi.Infrastructure
{
    public class ToDoItemContext :DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public ToDoItemContext(DbContextOptions<ToDoItemContext>options): base (options)
        {

        }
    }
}
