using AngularApi.Infrastructure;
using AngularApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTaskController : ControllerBase

    {
        private readonly ToDoItemContext _context;

        public MyTaskController(ToDoItemContext context)
        {
            _context = context;
        }
        [HttpGet("items")]
        public List<ToDoItem> getitems()
        {
            var result = from r in _context.ToDoItems select r;
            return result.ToList();

        }
        [HttpPost("items")]
        public ToDoItem createItem(ToDoItem item)
        {
            _context.Add(item);
            _context.SaveChanges();

            return item;
        }
        [HttpPut("items/{id}")]
        public ToDoItem updateItem(ToDoItem item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
