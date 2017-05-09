using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace leduchai.Model.Models
{
   [Table("Menus")]
    class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string URL { get; set; }

        public int? DisplayOrder { set; get; }
        
        //khoa ngoai
        [Required]
        public int GroupID { set; get; }

        [MaxLength(10)]
        public string Target { set; get; }

        //kieu bit
        [Required]
        public bool Status { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
    }
}
