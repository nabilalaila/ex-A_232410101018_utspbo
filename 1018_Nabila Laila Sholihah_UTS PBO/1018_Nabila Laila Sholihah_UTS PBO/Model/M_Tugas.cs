using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018_Nabila_Laila_Sholihah_UTS_PBO.Model
{
    public class M_Tugas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string judul_tugas { get; set; }
        [Required]
        public string deskripsi_tugas { get; set; }
        [Required]
        public DateOnly deadline_tugas { get; set; }
    }
}
