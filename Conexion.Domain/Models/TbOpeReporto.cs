using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpeReporto
{
    public Guid LngIdOpeReporto { get; set; }

    public Guid? LngIdOpeGeneral { get; set; }

    public int? IntIdMoneda { get; set; }

    public decimal? DblPrecioSucio { get; set; }

    public decimal? DblImporte { get; set; }

    public DateTime? FecOperacion { get; set; }

    public decimal? DblTasa { get; set; }

    public decimal? DblInteres { get; set; }

    public decimal? DblMontoFinal { get; set; }

    public Guid? IntIdVenPactado { get; set; }
}
