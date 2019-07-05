
namespace ContaWeb.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;


    public class Purchase : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres")]
        [Display(Name = "Documento No.")]
        public string NoDocument { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(45, ErrorMessage = "El Campo {0} Solo Puede Contener {1} Caracteres")]
        [Display(Name = "Tipo De Documento")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Valor Total")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Total { get; set; }

        [Required]
        [Display(Name = "Precio Neto")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Credito Fiscal")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IVA { get; set; }

        public Provider Provider { get; set; }

        public Client Client { get; set; }

        public User User { get; set; }




    }
}
