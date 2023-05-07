using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    [Table("HocSinh")]
    public class SinhVien
    {
        [Key]
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public string Lop { get; set; }
        public int Tuoi { get; set; }
    }
}
