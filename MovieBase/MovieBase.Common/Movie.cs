﻿using System.ComponentModel.DataAnnotations;

namespace MovieBase.Common;

public class Movie
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Director { get; set; } = string.Empty;

    public DateOnly Released { get; set; }
}
