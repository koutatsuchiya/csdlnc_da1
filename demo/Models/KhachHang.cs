namespace demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(5)]
        public string MaKH { get; set; }

        [StringLength(5)]
        public string Ho { get; set; }

        [StringLength(5)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngsinh { get; set; }

        public int? SoNha { get; set; }

        [StringLength(30)]
        public string Duong { get; set; }

        [StringLength(30)]
        public string Phuong { get; set; }

        [StringLength(30)]
        public string Quan { get; set; }

        [StringLength(30)]
        public string Tpho { get; set; }

        [StringLength(10)]
        public string DienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
