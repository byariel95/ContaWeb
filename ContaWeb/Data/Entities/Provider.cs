

namespace ContaWeb.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Provider : IEntity
    {
        public int Id { get; set; }

        [MaxLength(15)]
        [Required]
        [Display(Name = "NIT")]
        public string Nit { get; set; }

        [Required]
        [Display(Name = "Nombre de Proveedor")]
        [MaxLength(50, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres.")]
        public string Name { get; set; }

        public User User { get; set; }

    }
}
