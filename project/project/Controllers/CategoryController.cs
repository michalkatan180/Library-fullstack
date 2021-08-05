
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using DAL;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly BLL.Category c;
        private readonly Library library;
        public CategoryController(BLL.Category c, Library library)
        {
            this.c = c;
            this.library = library;
        }
  
        [HttpGet]
        [EnableCors("myPolicy")]
        public List<CategoryDTO> GetCategoriestList()
        {
            return c.GetCategoryDTOList();
        }

        [HttpGet("{id}")]
        [EnableCors("myPolicy")]
        public CategoryDTO GetCategory(int id)
        {
            return c.GetCategoryDTO(id);
        }

      
        [HttpPost]
        [EnableCors("myPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostCategory(DTO.CategoryDTO toAdd)
        {
            library.Categories.Add(c.GetCategory(toAdd));
            library.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        [EnableCors("myPolicy")]
        public ActionResult PutCategory(int id, CategoryDTO toEdit)
        {
            if (c == null) return NotFound();
            if (id != toEdit.id) return Conflict();
            CategoryDTO x = c.PutCategory(id, toEdit);
            if (x == null) return NotFound();
            return Ok(x);
        }


        //delete




    }
}
