namespace MasterPolApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Partners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partners()
        {
            PartnerProducts = new HashSet<PartnerProducts>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Director { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(50)]
        public string INN { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int Rating { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProducts> PartnerProducts { get; set; }
        public virtual int Discount
        {
            get
            {
                int totalSold = PartnerProducts?.Sum(pp => pp.Quantity) ?? 0;

                if (totalSold < 10000) return 0;
                if (totalSold < 50000) return 5;
                if (totalSold < 300000) return 10;
                return 15;
            }
        }
    }
}
