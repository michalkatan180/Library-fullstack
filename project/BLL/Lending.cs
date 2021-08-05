using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using AutoMapper;
using System.Linq;
namespace BLL
{
    public class Lending
    {
        private readonly Library library;
        private readonly IMapper mapper;
        public Lending(Library library, IMapper mapper)
        {
            this.library = library;
            this.mapper = mapper;
        }
        //מקבלת קוד ומחזירה השאלה לפי קוד
        public LendingDTO GetLendingById(int id)
        {
            DAL.Lendings l = library.Lendings.Find(id);
            return mapper.Map<LendingDTO>(l);

        }

        //מחזירה רשימת השאלות
        public List<LendingDTO> GetLendingsList()
        {
            List<DAL.Lendings> lendings = library.Lendings.ToList();
            List<LendingDTO> lendingsDTOs = new List<LendingDTO>();
            lendings.ForEach(l => lendingsDTOs.Add(cast.LendingCast.GetLendingDTO(l)));
            return lendingsDTOs;
        }


        //מקבלת קוד שואל ומחזירה אוסף השאלות של הספר
        public List<LendingDTO> GetListLendingsByBorrowerCode(int id)
        {
            List<DAL.Lendings> lendings = library.Lendings.Where(x => x.BorrowerId == id).ToList();
            List<LendingDTO> lendingsDTOs = new List<LendingDTO>();
            lendings.ForEach(l => lendingsDTOs.Add(mapper.Map<LendingDTO>(l)));
            return lendingsDTOs;
        }


        //מקבלת קוד ספר ומחזירה אוסף השאלות של הספר
        public List<LendingDTO> GetLendingsListByBookCode(int id)
        {
            List<DAL.Lendings> lendings = library.Lendings.Where(x => x.BookId == id).ToList();
            List<LendingDTO> lendingsDTOs = new List<LendingDTO>();
            lendings.ForEach(l => lendingsDTOs.Add(mapper.Map<LendingDTO>(l)));
            return lendingsDTOs;
        }

        //מחזירה מ-די-טי-או לדאל
        public DAL.Lendings GetLending(LendingDTO lendingDTO)
        {
            return mapper.Map<DAL.Lendings>(lendingDTO);
        }

        //מחיקת השאלה
        public LendingDTO DeleteLending(int id)
        {
            DAL.Lendings x = library.Lendings.Find(id);
            library.Lendings.Remove(x);
            library.SaveChanges();
            return mapper.Map<LendingDTO>(x);
        }

        /*   public List<LendingDTO> GetLendingDTO(List<Lendings> lens)
           {
               List<LendingDTO> bbb = new List<LendingDTO>();
               foreach (Lendings c in lens)
                   bbb.Add(cast.LendingCast.GetLendingDTO(c));
               return bbb;
           }
           public List<Lendings> GetLendingDTO(List<LendingDTO> lendingsDto)
           {
               List<Lendings> bbb = new List<Lendings>();
               foreach (LendingDTO c in lendingsDto)
                   bbb.Add(cast.LendingCast.GetLending(c));
               return bbb;
           }*/
    }
}
