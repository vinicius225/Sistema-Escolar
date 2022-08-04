using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_Escolar.DTO.Entities;
using Sistema_Escolar.DTO.Interface;

namespace Sistema_Escolar.DTO.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}