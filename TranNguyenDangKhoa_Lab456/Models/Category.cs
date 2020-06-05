using System.ComponentModel.DataAnnotations;
using TranNguyenDangKhoa_Lab456.Models;

namespace TranNguyenDangKhoa_Lab456.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [require]
        [StringLeng th(255)]
        public string Name { get; set; }
    }
}