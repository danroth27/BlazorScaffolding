using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorScaffolding.Models;

public class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    [Display(Name = "Release date")] // Blazor doesn't use this currently: https://github.com/dotnet/aspnetcore/issues/49147
    public DateOnly? ReleaseDate { get; set; }

    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}