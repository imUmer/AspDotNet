using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models;

public class Cars 
{
    private int Id { get; set;}
    [Required]
    private string? CarName { get; set;}
    private BrandName Brand { get; set;}
    
    private ModelYear Year { get; set;}
    [Range(50000, 1000000)]
    private Double Price {get; set;}

}

public enum BrandName { Mercedise, Toyota, Suzukie}
public enum ModelYear { yr_2000, yr_2001, yr_2002}