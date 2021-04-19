using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using efpostgres.DataModels;
using NetTopologySuite.Geometries;
using NpgsqlTypes;

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
    public int[] IntArray { get; set; }

    [Column("strarray")]
    public string[] StrArray { get; set; }

    [Column("jsonval", TypeName = "json")]
    //[Column("jsonval")]
    //public JsonTestData JsonVal { get; set; }
    public string JsonVal { get; set; }

    [Column("jsonbval", TypeName = "jsonb")]
    //[Column("jsonbval")]
    //public JsonTestData JsonbVal { get; set; }
    public string JsonbVal { get; set; }

    [Column("daterangeval")]
    public NpgsqlRange<DateTime> DateRangeVal { get; set; }

    [Column("inetval")]
    public IPAddress InetVal { get; set; }

    [Column("geoval")]
    public Point GeoVal { get; set; }

  }
}
