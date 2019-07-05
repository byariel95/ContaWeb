




namespace ContaWeb.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class PurchaseDetail : IEntity
    {
        public int Id { get; set; }

        
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalPurchases { get; set; }

       
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalCredit { get; set; }

        
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalAmount { get; set; }

        public Purchase Purchase { get; set; }
    }
}
