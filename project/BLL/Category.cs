using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using AutoMapper;
using System.Linq;


namespace BLL
{
    public class Category
    {
        private readonly Library library;
        private readonly IMapper mapper;
        public Category(Library library, IMapper mapper)
        {
            this.library = library;
            this.mapper = mapper;
        }

        public CategoryDTO GetCategoryDTO(int id)
        {
            DAL.Category category = library.Categories.Find(id);
            return mapper.Map<CategoryDTO>(category);
        }

        public DAL.Category GetCategory(CategoryDTO categoryDTO)
        {        //מחזירה מ-די-טי-או לדאל
            return mapper.Map<DAL.Category>(categoryDTO);
        }
        public List<CategoryDTO> GetCategoryDTOList()
        {

            List<DAL.Category> categories = library.Categories.ToList();
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            categories.ForEach(c => categoryDTOs.Add(mapper.Map<CategoryDTO>(c)));
            return categoryDTOs;
        }
       
        public CategoryDTO PutCategory(int id, CategoryDTO toEdit)
        {
            DAL.Category x = mapper.Map<DAL.Category>(toEdit);
            library.Entry(x).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            library.SaveChanges();
            return toEdit;
        }


        /*public List<CategoryDTO> GetCategoryDTO(List<DAL.Category> cats)
        {
            List<CategoryDTO> bbb = new List<CategoryDTO>();
            foreach (DAL.Category c in cats)
                bbb.Add(cast.CategoryCast.GetCategoryDTO(c));
            return bbb;
        }
        public List<DAL.Category> GetCategoryDTO(List<CategoryDTO> booksDto)
        {
            List<DAL.Category> bbb = new List<DAL.Category>();
            foreach (CategoryDTO c in booksDto)
                bbb.Add(cast.CategoryCast.GetCategory(c));
            return bbb;
        }*/

    }
}
