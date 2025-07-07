using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using BookStore.Authors;
using BookStore.Authors.Dtos;
using BookStore.Authors.Interfaces;
using BookStore.Web.Pages.Authors.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace BookStore.Web.Pages.Authors;
public class CreateModal : BookStorePageModel
{
    
    public List<SelectListItem> CountryList { get; set; }
    private readonly IAuthorAppService _service;
    public CreateModal(IAuthorAppService service)
    {
        _service = service;
    }
    
    
    [BindProperty]
    public CreateAuthorViewModel authorViewModel { get; set; }
   
    public void OnGet()
    {
        authorViewModel = new CreateAuthorViewModel();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateAuthorViewModel, CreateAuthorDto>(authorViewModel);
        await _service.CreateAsync(dto);
        return NoContent(); 
    }

}

