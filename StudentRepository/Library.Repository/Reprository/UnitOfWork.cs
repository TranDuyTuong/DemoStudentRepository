using Library.DomainData.DB;
using Library.DomainData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Reprository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentDBContext _Context;

        public IClassRepository Classes { get; }

        public IStudentRepository Students { get; }
        public UnitOfWork(StudentDBContext Context, IClassRepository ClassesRepo, IStudentRepository StudentRepo)
        {
            this._Context = Context;
            this.Classes = ClassesRepo;
            this.Students = StudentRepo;
        }

        public int Complete()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _Context.Dispose();
            }
        }
    }
}
