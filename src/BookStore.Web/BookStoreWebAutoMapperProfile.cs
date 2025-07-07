using AutoMapper;
using BookStore.Authors.Dtos;
using BookStore.Books.Dtos;
using BookStore.Web.Pages.Authors.ViewModels;

namespace BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        CreateMap<CreateAuthorViewModel, CreateAuthorDto>();
        CreateMap<AuthorDto, Pages.Authors.EditModal.EditAuthorViewModel>();
        CreateMap<Pages.Authors.EditModal.EditAuthorViewModel, UpdateAuthorDto>();
        
        CreateMap<BookStore.Web.Pages.Books.CreateModalModel.CreateBookViewModel, CreateUpdateBookDto>();
        CreateMap<BookDto, BookStore.Web.Pages.Books.EditModalModel.EditBookViewModel>();
        CreateMap<BookStore.Web.Pages.Books.EditModalModel.EditBookViewModel, CreateUpdateBookDto>();

    }
}
