using BookStore.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Authors.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BookStore.Books.Interfaces
{
    public interface IBookAppService :
    ICrudAppService<
        BookDto,
        Guid,
        PagedAndSortedResultRequestDto, 
        CreateUpdateBookDto>
    {
        Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();
        
    }
}