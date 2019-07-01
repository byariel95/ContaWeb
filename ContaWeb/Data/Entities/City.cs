

namespace ContaWeb.Data.Entities
{

    using System.ComponentModel.DataAnnotations;
    public class City : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres.")]
        public string Name { get; set; }

    }
}
