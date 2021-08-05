using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DTO;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendingController : Controller
    {
        private readonly BLL.Lending l;
        private readonly Library library;
        public LendingController(BLL.Lending l, Library library)
        {
            this.l = l;
            this.library = library;
        }

        [HttpGet]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LendingDTO))]
        public ActionResult<IEnumerable<LendingDTO>> GetLendingList()
        {
            return Ok(l.GetLendingsList());
        }

        [HttpGet("{id}")]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LendingDTO))]
        public IActionResult GetLending(int id)
        {
            l.GetLendingById(id);
            if (l == null) return NotFound();
            return Ok(l.GetLendingById(id));
        }

        [HttpGet("byBookCode/{id}")]
        [EnableCors("myPolicy")]
        public ActionResult<IEnumerable<LendingDTO>> GetLendingsListByBookCode(int id)
        {
            return l.GetLendingsListByBookCode(id);
        }


        [HttpGet("byBorrowerCode/{id}")]
        [EnableCors("myPolicy")]
        public List<LendingDTO> GetLendingsListByBoroowerCode(int id)
        {
            return l.GetListLendingsByBorrowerCode(id);
        }

        [HttpPost]
        //[EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostLending(DTO.LendingDTO toAdd)
        {
            library.Lendings.Add(l.GetLending(toAdd));
            library.SaveChanges();
            return Ok(toAdd);
        }


        [HttpDelete]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteLending(int id)
        {
            LendingDTO x = l.DeleteLending(id);
            if (x == null) return NotFound();
            return Ok(x);
        }



        //put
    }
}
