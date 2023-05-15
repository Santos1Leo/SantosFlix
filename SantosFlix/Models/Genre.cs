using  System. ComponentModel.DataAnnotations;

namespace SantosFlix.Models;

 public class Genre
  {
    [Key] // É uma anotação para chave primaria
    
    public byte Id {get; set; }
    
    [Required] // Requerido - Not Null no banco; Torna o nome obrigatorio
    [StringLength(30)] // Tamnho maximo da pro
    public string Name {get; set; }    
  }
