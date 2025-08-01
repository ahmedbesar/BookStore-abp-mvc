using System;
using Volo.Abp.Application.Dtos;

namespace BookStore.Books.Dtos;

public class AuthorLookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}