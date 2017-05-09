﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace leduchai.Model.Models
{
    [Table("Pages")]
    class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        // chỉ ra kiểu dữ liệu chính xác là varchar
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { get; set; }
    }
}
