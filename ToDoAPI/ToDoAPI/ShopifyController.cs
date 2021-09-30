using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopifySharp;
using ShopifySharp.Lists;

namespace ToDoAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopifyProductController : ControllerBase
    {
        string myShopifyUrl = "https://cicom-erp-test-development.myshopify.com";
        string privateAppPassword = "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";
        
        //public ShopifyProductController(ToDoContext context)
        //{
        //    _context = context;
        //}

        // GET: api/ToDoes
        [HttpGet]
        public async Task<ActionResult<ListResult<Product>>> GetProducts()
        {
            var service = new ProductService(myShopifyUrl, privateAppPassword);
            ListResult<Product> products = await service.ListAsync();
            return products;

        }

        //// GET: api/ToDoes/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<ToDo>> GetToDo(int id)
        //{
        //    var toDo = await _context.TodoItems.FindAsync(id);

        //    if (toDo == null)
        //    {
        //        return NotFound();
        //    }

        //    return toDo;
        //}

        //// PUT: api/ToDoes/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutToDo(int id, ToDo toDo)
        //{
        //    if (id != toDo.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(toDo).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ToDoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/ToDoes
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<ToDo>> PostToDo(ToDo toDo)
        //{
        //    _context.TodoItems.Add(toDo);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetToDo", new { id = toDo.Id }, toDo);
        //}

        //// DELETE: api/ToDoes/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<ToDo>> DeleteToDo(int id)
        //{
        //    var toDo = await _context.TodoItems.FindAsync(id);
        //    if (toDo == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TodoItems.Remove(toDo);
        //    await _context.SaveChangesAsync();

        //    return toDo;
        //}

        //private bool ToDoExists(int id)
        //{
        //    return _context.TodoItems.Any(e => e.Id == id);
        //}
    }
}
