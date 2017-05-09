using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace leduchai.Model.Models
{
    [Table("Footers")]  //ten bang trong csdl khi gen ra
    class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }
        
        [Required]
        public string Content { get; set; }

    }
}
