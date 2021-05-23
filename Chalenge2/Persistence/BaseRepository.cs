using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Challenge2.Persistence.Contexts;


namespace Challenge2.Persistence
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}