using BookStore.Books.Dtos;
using BookStore.Books.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BookStore.Web.Pages.Books
{
    public class CreateModalModel : BookStorePageModel
    {
        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}
