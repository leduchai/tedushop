using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace leduchai.Model.Models
{
    [Table("VisitorStatistics")]
    class VisitorStatistic
    {
        //???? kieu Guid la kieu deo gi???
        [Key]
        public Guid ID { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }

        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
