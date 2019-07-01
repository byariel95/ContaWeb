


namespace ContaWeb.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.AspNetCore.Identity;
    public class User: IdentityUser
    {

        [MaxLength(15)]
        [Required]
        [Display(Name = "NIT")]
        public string Nit { get; set; }

        [Display(Name = "Nombres")]
        
        [MaxLength(60, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(60, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres ")]
        public string LastName { get; set; }

        [MaxLength(60, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres.")]
        public string Address { get; set; }


        [Display(Name = "Telefono")]
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        [Display(Name = "Nombre Completo")]
        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }


        [Display(Name = "Email Confirmado")]
        public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }

        [NotMapped]
        [Display(Name = "¿Es Administrador?")]
        public bool IsAdmin { get; set; }

        public DateTime BirthDate { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}
