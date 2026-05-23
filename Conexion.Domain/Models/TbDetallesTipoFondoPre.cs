using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDetallesTipoFondoPre
{
    public int LngIdDetallesTipoFondoPres { get; set; }

    public int? LngIdSolicitudrecurso { get; set; }

    public int? IntIdTipoFondos { get; set; }

    public int? LngIdClienteOp { get; set; }

    public decimal? DblImporte { get; set; }

    public DateTime? FecRegistro { get; set; }
}
