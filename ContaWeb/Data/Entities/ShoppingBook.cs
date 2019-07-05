

namespace ContaWeb.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class ShoppingBook : IEntity
    {
        public int Id { get; set; }

        [MaxLength(12)]
        [Required]
        [Display(Name = "Mes")]
        public string Month { get; set; }
     
        [Required]
        [MaxLength(5)]
        [Display(Name = "Año")]
        public string Year { get; set; }

        [MaxLength(6)]
        public string Folio { get; set; }


        public IEnumerable<PurchaseDetail> Totals { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal TotalPurchases { get { return this.Totals == null ? 0 : this.Totals.Sum(i => i.TotalPurchases); } }

        
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal TotalCredit { get { return this.Totals == null ? 0 : this.Totals.Sum(i => i.TotalCredit); } }


        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal TotalAmount { get { return this.Totals == null ? 0 : this.Totals.Sum(i => i.TotalAmount); } }

        public User User { get; set; }
    }
}
