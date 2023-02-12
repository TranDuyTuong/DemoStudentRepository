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
    public class ClassReprository : GenericRepository<T_Class>, IClassRepository
    {
        public ClassReprository(StudentDBContext context) : base(context)
        {

        }
        public async Task<IEnumerable<T_Class>> GetClassByClassName(string NameClass)
        {
            return await _context.T_Classes.Where(c => c.NameClass.Contains(NameClass)).ToListAsync();
        }

    }
}
