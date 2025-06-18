namespace MasterPolApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PartnerProducts
    {
        public int Id { get; set; }

        public int PartnerId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime SaleDate { get; set; }

        public virtual Partners Partners { get; set; }

        public virtual Products Products { get; set; }
    }
}
