using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace leduchai.Model.Models
{
    [Table("ProductTags")]
    class ProductTag
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}
