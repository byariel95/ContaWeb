

namespace ContaWeb.Data.Entities
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Client : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "NIT")]
        [MaxLength(15, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres")]
        public string Nit { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(60, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres")]
        public string Name { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(60, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres")]
        public string LastName { get; set; }

        [Display(Name = "Nombre o Razon Social")]
        public string FullName { get { return $"{this.Name} {this.LastName}"; } }

        [Display(Name = "Activo")]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [Display(Name = "Fecha De Nacimiento")]
        public DateTime? Bhirtday { get; set; }

        public User User { get; set; }

    }
}
