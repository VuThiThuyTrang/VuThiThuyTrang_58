using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VuThiThuyTrang_58.Models
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]
        public string MaSanPham { get; set; }
        [AllowHtml]
        public string TenSanPham { get; set; }
        public int MaNhaCungCap { get; set; }
    }
}