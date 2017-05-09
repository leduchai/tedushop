using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace leduchai.Model.Models
{
    [Table("Products")]
    class Product: Audiable
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }
       public string CategoryID { set; get; }
        public string Image { set; get; }

        //????????
        public XElement MoreImages { set; get; }


        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { get; set; }
        public string Description { get; set; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
