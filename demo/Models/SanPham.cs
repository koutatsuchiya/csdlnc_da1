namespace demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CT_HoaDon = new HashSet<CT_HoaDon>();
        }

        [Key]
        [StringLength(5)]
        public string MaSP { get; set; }

        [StringLength(20)]
        public string TenSP { get; set; }

        public int? SoLuongTon { get; set; }

        [StringLength(1)]
        public string Mota { get; set; }

        public int? Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HoaDon> CT_HoaDon { get; set; }
    }
}
