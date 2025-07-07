using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using BookStore.Authors;
using BookStore.Authors.Dtos;
using BookStore.Authors.Interfaces;
using BookStore.Web.Pages;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace BookStore.Web.Pages.Authors;

public class EditModal : BookStorePageModel
{
    [BindProperty]
    public EditAuthorViewModel Author { get; set; }

    private readonly IAuthorAppService _authorAppService;

    public EditModal(IAuthorAppService authorAppService)
    {
        _authorAppService = authorAppService;
    }

    public async Task OnGetAsync(Guid id)
    {
        var authorDto = await _authorAppService.GetAsync(id);
        Author = ObjectMapper.Map<AuthorDto, EditAuthorViewModel>(authorDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _authorAppService.UpdateAsync(
            Author.Id,
            ObjectMapper.Map<EditAuthorViewModel, UpdateAuthorDto>(Author)
        );

        return NoContent();
    }

    public class EditAuthorViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [Required]
        [StringLength(AuthorConsts.MaxNameLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [TextArea]
        public string? ShortBio { get; set; }
    }
}