using HHShops.Application.Repositories.IRepositories;
using HHShops.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using System.Net.WebSockets;

namespace HHShops.Application.Repositories.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> _dbSet;
        private readonly hhShopDbContext _context;

        public GenericRepository(hhShopDbContext context)
        {
            _dbSet = context.Set<TEntity>();
            _context = context;
        }

        public bool CheckContains(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Count<TEntity>(predicate) > 0;
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> where)
        {
            return await _dbSet.CountAsync(where);
        }

        public TEntity Create(TEntity entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return entity;
        }

        public TEntity Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            return entity;
        }

        public void DeleteMulti(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = _dbSet.Where<TEntity>(where).AsEnumerable();
            foreach (TEntity obj in objects)
            {
                _dbSet.Remove(obj);
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(string[] includes = null)
        {
            // xử lý bao gồm các đối tượng liên kết nếu được áp dụng
            if(includes != null && includes.Count() > 0)
            {
                var query = _context.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                //AsQueryable chuyển đổi từ IEnumerable sang IQueryable
                return query.AsQueryable();
            }
            return  _context.Set<TEntity>().AsQueryable();
        }

        public IEnumerable<TEntity> GetMultiAsync(Expression<Func<TEntity, bool>> predicate, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = _context.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                }
                //AsQueryable chuyển đổi từ IEnumerable sang IQueryable
                 return query.Where<TEntity>(predicate).AsQueryable<TEntity>();
            }
            return _context.Set<TEntity>().Where<TEntity>(predicate).AsQueryable<TEntity>();
        }

        public  IEnumerable<TEntity> GetMultiPagingAsync(Expression<Func<TEntity, bool>> predicate , out int total, int index = 0, int size = 50, string[] includes = null)
        {
            int skipCount = index * size;
            IQueryable<TEntity> _resetSet;
            if(includes != null && includes.Count() > 0)
            {
                var query = _context.Set<TEntity>().Include(includes.First());
                foreach(var include in includes.Skip(1))
                {
                    query=query.Include(include);        
                }
                _resetSet = predicate != null ? query.Where<TEntity>(predicate).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = predicate != null ? _context.Set<TEntity>().Where<TEntity>(predicate).AsQueryable() : _context.Set<TEntity>().AsQueryable();
            }
            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }
        

        public async Task<TEntity> GetSingleByConditionAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null)
        {
            if(includes != null && includes.Count() > 0)
            {
                var query = _context.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                {
                    query = query.Include(include);
                }
                return await query.FirstOrDefaultAsync(expression);
            }
            return await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        }

        public async Task<TEntity> GetSingleByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
