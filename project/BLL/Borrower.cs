using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DAL;
using DTO;
using System.Linq;

namespace BLL
{
    public class Borrower
    {
        private readonly Library library;
        private readonly IMapper mapper;
        public Borrower(Library library, IMapper mapper)
        {
            this.library = library;
            this.mapper = mapper;
        }
        public BorrowerDTO GetBorrowerDTOById(int id)
        {
            DAL.Borrower b = library.Borrowers.Find(id);
            return mapper.Map<BorrowerDTO>(b);
        }

        public List<BorrowerDTO> GetBorrowerDTOList()
        {
            List<DAL.Borrower> borrowers = library.Borrowers.ToList();
            List<BorrowerDTO> borrowersDto = new List<BorrowerDTO>();
            borrowers.ForEach(b => borrowersDto.Add(mapper.Map<BorrowerDTO>(b)));
            return borrowersDto;
        }


        //מחזירה מ-די-טי-או לדאל
        public DAL.Borrower GetBorrower(BorrowerDTO borrowerDTO)
        {
            return mapper.Map<DAL.Borrower>(borrowerDTO);
        }

        public BorrowerDTO DeleteBorrower(int id)
        {
            DAL.Borrower x = library.Borrowers.Find(id);
            library.Borrowers.Remove(x);
            return mapper.Map<BorrowerDTO>(x);
        }
    
        public BorrowerDTO PutBorrower(BorrowerDTO toEdit)
        {
           DAL.Borrower x= mapper.Map<DAL.Borrower>(toEdit);
            library.Entry(x).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            library.SaveChanges();
            return toEdit;
        }

    }
}
