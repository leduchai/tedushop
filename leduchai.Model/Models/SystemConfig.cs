﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace leduchai.Model.Models
{
    [Table("SystemConfigs")]
    class SystemConfig
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Code { set; get; }

        [MaxLength(50)]
        public string ValueString { get; set; }

        public int? ValueInt { set; get; }
    }
}
