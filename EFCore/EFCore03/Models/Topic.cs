using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C44_G03_EFCore03.Models
{
    [Table("Topics", Schema = "dbo")]
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TopicId { get; set; }

        [Column("TopicName", TypeName = "varchar")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string TopicName { get; set; }
    }
}