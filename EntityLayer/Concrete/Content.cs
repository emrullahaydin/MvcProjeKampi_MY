using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(5100)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; } // Birebir ilişki kuruluyor. Üst satır ilişkili tablodaki alanın aynısı olmak zorunda.

        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
