using Library.DomainData.DB;
using Library.DomainData.Interfaces;
using Library.TableData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Reprository
{
    public class StudentRepository : GenericRepository<T_Student>, IStudentRepository
    {
        public StudentRepository(StudentDBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<T_Student>> GetAllSutdent()
        {
            var AllStudent = await _context.T_Students.ToListAsync();
            return AllStudent;
        }
    }
}
