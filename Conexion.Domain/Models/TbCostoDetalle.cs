using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCostoDetalle
{
    public int LngIdCostoDetalle { get; set; }

    public int LngIdProducto { get; set; }

    public decimal? DblTotalGpo { get; set; }

    public int? NumConcepto { get; set; }

    public decimal? DblCostoP { get; set; }

    public int? IntIdConcepto { get; set; }
}
