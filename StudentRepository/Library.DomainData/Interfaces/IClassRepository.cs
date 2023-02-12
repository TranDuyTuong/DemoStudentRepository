using Library.TableData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.Interfaces
{
    public interface IClassRepository : IGenericRepository<T_Class>
    {
        Task<IEnumerable<T_Class>> GetClassByClassName(string NameClass);
    }
}
