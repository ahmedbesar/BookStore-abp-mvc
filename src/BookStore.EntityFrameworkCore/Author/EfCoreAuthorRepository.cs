using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using BookStore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace BookStore.Authors;

public class EfCoreAuthorRepository
    : EfCoreRepository<BookStoreDbContext, Author, Guid>,
        IAuthorRepository
{
    public EfCoreAuthorRepository(
        IDbContextProvider<BookStoreDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }

    public async Task<Author> FindByNameAsync(string name)
    {
        var dbSet = await GetDbSetAsync();
        var author = await dbSet.FirstOrDefaultAsync(a=>a.Name==name);
        return author;
    }

    public async Task<List<Author>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null)
    {
        var dbSet = await GetDbSetAsync();


        List<Author> authors = dbSet.WhereIf(
              ! filter.IsNullOrWhiteSpace(), a => a.Name.Contains(filter))
            .OrderBy(sorting).Take(maxResultCount).Skip(skipCount).ToList();

        return authors;
    }
}