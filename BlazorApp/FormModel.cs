using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp
{
    public class FormModel
    {
        [Required]
        [Range(10, 10000)]
        public int ItemCount { get; set; }
    }
}
