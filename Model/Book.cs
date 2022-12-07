using System.ComponentModel.DataAnnotations;

namespace TP_ISIE_21.Model {

    public class Book {
    
    [Key]
    public int Id {get; set;}

    [Required]
    public string Name {get; set;}

    [Display(Name="Author Name")]
    public string Author {get; set;}
}

}
