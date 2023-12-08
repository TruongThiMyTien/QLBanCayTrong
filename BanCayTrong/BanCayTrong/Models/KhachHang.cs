using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanCayTrong.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DiaChi = new HashSet<DiaChi>();
            HoaDon = new HashSet<HoaDon>();
        }

        [Key]
        [Column("makh")]
        public int Makh { get; set; }
        [Required]
        [Column("ten")]
        [StringLength(100)]
        public string Ten { get; set; }
        [Required]
        [Column("dienthoai")]
        [StringLength(20)]
        public string Dienthoai { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("matkhau")]
        [StringLength(255)]
        public string Matkhau { get; set; }

        [InverseProperty("MakhNavigation")]
        public virtual ICollection<DiaChi> DiaChi { get; set; }
        [InverseProperty("MakhNavigation")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
