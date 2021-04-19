using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efpostgres.Database.Entities
{
  [Table("identitydata", Schema = "haintondotnet")]
  public class IdentityData
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("pkid")]
    public int Pkid { get; set; }

    [Column("textval")]
    public string TextVal { get; set; }

  }
}
