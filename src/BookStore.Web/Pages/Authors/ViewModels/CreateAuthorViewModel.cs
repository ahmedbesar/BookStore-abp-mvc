using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Authors;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace BookStore.Web.Pages.Authors.ViewModels;

public class CreateAuthorViewModel
{
    [Required]
    [StringLength(AuthorConsts.MaxNameLength)]
    public string Name { get; set; } = string.Empty;

    [Required] [DataType(DataType.Date)] public DateTime BirthDate { get; set; } = DateTime.UtcNow;
    [TextArea] public string? ShortBio { get; set; }
}

public enum CarType
{
    Sedan,
    Hatchback,
    StationWagon,
    Coupe
}