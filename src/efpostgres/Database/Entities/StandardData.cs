using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efpostgres.Database.Entities
{
  [Table("standarddata", Schema = "haintondotnet")]
  public class StandardData
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("pkid")]
    public int Pkid { get; set; }

    [Column("intval")]
    public int IntVal { get; set; }

    [Column("decimalval")]
    public decimal DecimalVal { get; set; }

    [Column("stringval")]
    public string StringVal { get; set; }

    [Column("textval")]
    public string TextVal { get; set; }

    [Column("boolval")]
    public bool BoolVal { get; set; }
  }
}
