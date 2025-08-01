﻿using BookStore.Books.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace BookStore.Books.Dtos
{
    public class BookDto : AuditedEntityDto<Guid>
    {  
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
     

    }
}
