using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leduchai.Model.Models
{
    interface IAuditable
    {
        DateTime? CreateDate { get; set; }
        string CreatedBy { get; set; }
        string UpdateBy { get; set; }
        DateTime? UpdatedDate { get; set; }

        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}
