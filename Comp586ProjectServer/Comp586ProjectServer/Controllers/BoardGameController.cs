using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Comp586ProjectServer.Models;

namespace Comp586ProjectServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardGameController : ControllerBase
    {
        private readonly spa586Context _context;

        public BoardGameController(spa586Context context)
        {
            _context = context;
        }

        // GET: api/BoardGame
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoardGame>>> GetBoardGames()
        {
            return await _context.BoardGames.ToListAsync();
        }

        // GET: api/BoardGame/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BoardGame>> GetBoardGame(int id)
        {
            var boardGame = await _context.BoardGames.FindAsync(id);

            if (boardGame == null)
            {
                return NotFound();
            }

            return boardGame;
        }

        // PUT: api/BoardGame/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoardGame(int id, BoardGame boardGame)
        {
            if (id != boardGame.Id)
            {
                return BadRequest();
            }

            _context.Entry(boardGame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoardGameExists(id))
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

        // POST: api/BoardGame
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BoardGame>> PostBoardGame(BoardGame boardGame)
        {
            _context.BoardGames.Add(boardGame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoardGame", new { id = boardGame.Id }, boardGame);
        }

        // DELETE: api/BoardGame/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BoardGame>> DeleteBoardGame(int id)
        {
            var boardGame = await _context.BoardGames.FindAsync(id);
            if (boardGame == null)
            {
                return NotFound();
            }

            _context.BoardGames.Remove(boardGame);
            await _context.SaveChangesAsync();

            return boardGame;
        }

        private bool BoardGameExists(int id)
        {
            return _context.BoardGames.Any(e => e.Id == id);
        }
    }
}
