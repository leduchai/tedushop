using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace leduchai.Model.Models
{
    [Table("PostTags")]
    class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
