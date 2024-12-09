using libreria_DALS.Data.Services;
using libreria_DALS.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libreria_DALS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsControllers : ControllerBase
    {
        private AuthorsService _authorsServices;

        public AuthorsControllers(AuthorsService authorsServices)
        {
            _authorsServices = authorsServices;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorsServices.AddAuthor(author);
            return Ok();
        }

        [HttpGet("get-author-with-books-by-id/(id)")]
        public IActionResult GetAuthorsWithBooks(int id)
        {
           var resonse = _authorsServices.GetAuthorWithBook(id);
            return Ok(resonse);
        }
    }
}
