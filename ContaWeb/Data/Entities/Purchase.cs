
namespace ContaWeb.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    

    public class Purchase : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Documento No.")]
        public string NoDocument { get; set; }

        [Display(Name = "Fecha")]
        public DateTime Date { get; set; }

        [Display(Name = "Tipo De Documento")]
        public string Type { get; set; }

        [Display(Name = "NIT")]
        public  string Nit { get; set; }

        [Display(Name = "Valor Total")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Total { get; set; }

        [Display(Name = "Precio Neto")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Credito Fiscal")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IVA { get; set; }
    }
}
