using Library.TableData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.Interfaces
{
    public interface IStudentRepository : IGenericRepository<T_Student>
    {
        Task<IEnumerable<T_Student>> GetAllSutdent();
    }
}
