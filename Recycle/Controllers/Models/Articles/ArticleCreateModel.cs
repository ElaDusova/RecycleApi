﻿using RecycleApp.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Recycle.Api.Controllers.Models.Articles
{
    public class ArticleCreateModel
    {
        [Required(ErrorMessage = "{0} is required.", AllowEmptyStrings = false)]
        public string Heading { get; set; } = null!;

        public string? Annotation { get; set; }
    }
    public static class ArticleCreateModelExtensions
    {
        public static ArticleCreateModel ToUpdate(this Article source) => new()
        {
            Heading = source.Heading,
            Annotation = source.Annotation,
        };
    }
}
