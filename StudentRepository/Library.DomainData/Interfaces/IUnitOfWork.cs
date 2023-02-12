using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IClassRepository Classes { get; }
        IStudentRepository Students { get; }
        int Complete();
    }
}
