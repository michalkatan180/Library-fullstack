using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using BLL;
using Microsoft.AspNetCore.Cors;
using DAL;
using Microsoft.AspNetCore.Http;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowerController : Controller
    {

        private readonly BLL.Borrower b;
        private readonly Library library;
        public BorrowerController(BLL.Borrower b, Library library)
        {
            this.b = b;
            this.library = library;
        }
        [HttpGet("{id}")]
        [EnableCors("myPolicy")]
        public BorrowerDTO GetBorrower(int id)
        {
            return b.GetBorrowerDTOById(id);
        }
        
        [HttpGet()]
        [EnableCors("myPolicy")]
        public List<BorrowerDTO> GetBorrowersList()
        {
            return b.GetBorrowerDTOList();
        }

        [HttpPost]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostBorrower(DTO.BorrowerDTO toAdd)
        {
            library.Borrowers.Add(b.GetBorrower(toAdd));
            library.SaveChanges();
            return Ok(toAdd);
        }

        [HttpDelete("{id}")]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteBook(int id)
        {
            BorrowerDTO x =b.DeleteBorrower (id);
            if (x == null) return NotFound();
            return Ok(x);
        }

        [HttpPut("{id}")]
        [EnableCors("myPolicy")]
        public ActionResult PutBorrower(int id, BorrowerDTO toEdit)
        {
            if (b == null) return NotFound();
            if (id != toEdit.id) return Conflict();
            BorrowerDTO x = b.PutBorrower(toEdit);
            if (x == null) return NotFound();
            return Ok(x);
        }
    }
}
