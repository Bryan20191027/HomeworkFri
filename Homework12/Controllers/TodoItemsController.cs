using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDB;

        public OrderController(OrderContext context)
        {
           orderDB = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetTodoItems()
        {
            return await orderDB.Orders.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetTodoItem(long id)
        {
            var order = await orderDB.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(string id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

           orderDB.Entry(order).State = EntityState.Modified;

            try
            {
                await orderDB.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
       [HttpPost]
public async Task<ActionResult<Order>> PostTodoItem(Order order)
{
    orderDB.Orders.Add(order);
    await orderDB.SaveChangesAsync();

    //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
    return CreatedAtAction(nameof(GetTodoItem), new { id = order.Id }, order);
}

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(string id)
        {
            var order = await orderDB.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            orderDB.Orders.Remove(order);
            await orderDB.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoItemExists(string id)
        {
            return orderDB.Orders.Any(e => e.Id == id);
        }
    }
}
