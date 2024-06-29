using Api_Mvc_Entity.Context;
using Api_Mvc_Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Mvc_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Produto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoModel>>> GetProdutos()
        {
            if (_context.Produto == null)
            {
                return NotFound();
            }

            return await _context.Produto.ToListAsync();
        }

        // GET: api/Produto/1
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoModel>> GetProduto(int id)
        {
            if (_context.Produto == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return produto;
        }

        // PUT: api/Produto/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(int id, ProdutoModel produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Produto
        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> PostProduto(ProdutoModel produto)
        {
            _context.Produto.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostProduto), new { id = produto.Id }, produto);
        }

        // DELETE: api/Produto/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            if (_context.Produto == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return (_context.Produto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
