using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMovies.Models
{
	public class PostDTO
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostDTO ()
        {
            this.Comments = new HashSet<CommentDTO>();
        }

        public int PostId { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public System.DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentDTO> Comments { get; set; }
    }
}
