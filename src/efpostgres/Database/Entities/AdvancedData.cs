using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efpostgres.Database.Entities
{
  [Table("advanceddata", Schema = "haintondotnet")]
  public class AdvancedData
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("pkid")]
    public int Pkid { get; set; }

    [Column("intarray")]
    public int IntArray { get; set; }

    [Column("strarray")]
    public decimal StrArray { get; set; }

    [Column("jsonval")]
    public string JsonVal { get; set; }

    [Column("jsonbval")]
    public string JsonbVal { get; set; }

    [Column("daterangeval")]
    public bool DateRangeVal { get; set; }

    [Column("inetval")]
    public bool InetVal { get; set; }

    [Column("geoval")]
    public bool GeoVal { get; set; }

  }
}
