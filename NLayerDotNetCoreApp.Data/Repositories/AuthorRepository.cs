using NLayerDotNetCoreApp.Core.Models;
using NLayerDotNetCoreApp.Core.Repositories;
using NLayerDotNetCoreApp.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerDotNetCoreApp.Data.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
