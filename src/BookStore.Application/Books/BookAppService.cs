using BookStore.Books.Dtos;
using BookStore.Books.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BookStore.Books
{
    public class BookAppService :
      CrudAppService<
          Book,
          BookDto,
          Guid,
          PagedAndSortedResultRequestDto,
          CreateUpdateBookDto>,
      IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {

        }

        public override Task<BookDto> GetAsync(Guid id)
        {
            return base.GetAsync(id);
        }
        public override Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return base.GetListAsync(input);
        }
        public override Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
        {
            return base.UpdateAsync(id, input);
        }
    }
}