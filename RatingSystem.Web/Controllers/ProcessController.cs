using Microsoft.AspNetCore.Mvc;
using RatingSystem.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace RatingSystem.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult Rank([FromBody]List<Book> books)
        {
            if (books == null || books.Count < 2)
            {
                return BadRequest("Please provide a list of books.");
            }

            return Ok(RankBooks(books));
        }

        private List<Book> RankBooks(List<Book> books)
        {
            var averageRaters = books.Average(x => x.TotalRaters);
            var averageRating = books.Average(x => x.AverageRating);

            return books.Select(x => CalculateRanking(x, averageRaters, averageRating))
                .OrderByDescending(x => x.Ranking)
                .ToList();
        }

        private Book CalculateRanking(Book book, double averageNumberOfRaters, double averageRating)
        {
            book.Ranking = ((averageNumberOfRaters * averageRating) + (book.TotalRaters * book.AverageRating)) /
                           (averageNumberOfRaters + book.TotalRaters);
            return book;
        }
    }
}