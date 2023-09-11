using NLayerDotNetCoreApp.Core.UnitOfWorks;
using NLayerDotNetCoreApp.Data.EntityFramework;

namespace NLayerDotNetCoreApp.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
