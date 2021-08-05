using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
namespace BLL.cast
{
    public class CategoryCast
    {
        public static CategoryDTO GetCategoryDTO(DAL.Category cat)
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.color = cat.Color;
            categoryDTO.description = cat.Description;
            categoryDTO.id = cat.Id;
            categoryDTO.name = cat.Name;

            return categoryDTO;
        }
   
        public static DAL.Category GetCategory(CategoryDTO categoryDto)
        {
            DAL.Category c = new DAL.Category();
            c.Color = categoryDto.color;
            c.Description = categoryDto.description;
            c.Id = categoryDto.id;
            c.Name = categoryDto.name;
       
            return c;
        }
    
    }
}
