using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace leduchai.Model.Models
{
    public abstract class Audiable: IAuditable
    {
        //1 lớp kế thừa giao diện thì phải triển khai tất cả giao diện của nó

       public  DateTime? CreateDate { get; set; }

        [MaxLength(256)]
       public   string CreatedBy { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }
        public   DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
