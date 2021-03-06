﻿using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class EtiketRepository : Repository<Etiket>, IEtiketRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public EtiketRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Blog>> GetAllWithBlogsByIdAsync(int blogId)
        {
            return await _context.Blogs.Where(x => x.Id == blogId).ToListAsync();
            //return await _context.Blogs.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == blogId);
        }
    }
}
