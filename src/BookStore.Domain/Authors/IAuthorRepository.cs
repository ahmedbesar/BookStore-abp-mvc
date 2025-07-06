using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Authors;
using Volo.Abp.Domain.Repositories;
public interface IAuthorRepository : IRepository<Author, Guid>
{ 
    Task<Author> FindByNameAsync(string name);

    Task<List<Author>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null
    );
}