using BookStore.Books;
using BookStore.Books.Dtos;
using BookStore.Books.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace BookStore.Web.Pages.Books
{
    public class EditModalModel : BookStorePageModel
    {
        private readonly IBookAppService _bookAppService;

        public EditModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        [HiddenInput]
        [BindProperty(SupportsGet =true)]
        public Guid Id { get; set; }
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        public async Task OnGetAsync()
        {
            var bookDto = await _bookAppService.GetAsync(Id);
            Book = ObjectMapper.Map<BookDto, CreateUpdateBookDto>(bookDto);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.UpdateAsync(Id , Book);
            return NoContent();
        }
    }
}
