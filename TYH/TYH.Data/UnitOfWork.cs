using TYH.EntityFrameworkCore;

namespace TYH.Data
{
    class UnitOfWork:IUnitOfWork
    {
        private readonly TYHDbContext _context;
        public UnitOfWork(TYHDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
   
}
