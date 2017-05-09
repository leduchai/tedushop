using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace leduchai.Model.Models
{
    [Table("Slides")]
    class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

       
        [MaxLength(256)]
        public string Description { set; get; }

        
        [MaxLength(256)]
        public string Image { set; get; }

       
        [MaxLength(256)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        public bool Status { set; get; }
    }
}
