

namespace ContaWeb.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public class Country : IEntity
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres")]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }

        [Display(Name = "# Ciudades")]
        public int NumberCities { get { return this.Cities == null ? 0 : this.Cities.Count; } }
    }
}
