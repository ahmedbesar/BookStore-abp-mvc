using AutoMapper;
using BookStore.Books.Dtos;
using BookStore.Books;
using BookStore.Authors.Dtos;
using BookStore.Authors;

namespace BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<BookDto, CreateUpdateBookDto>();
      
        CreateMap<Author, AuthorDto>();

    }
}
