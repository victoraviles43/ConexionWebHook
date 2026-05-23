using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRutaFinanciamiento
{
    public int IntIdRutaFinanciamiento { get; set; }

    public int? LngIdFinanciamiento { get; set; }

    public string? TxtRutaFinanciamiento { get; set; }

    public DateTime? FecRutaFinanciamiento { get; set; }

    public byte[]? ImgComprobante { get; set; }

    public byte[]? BinDocumento { get; set; }

    public string? TxtExtension { get; set; }

    public string? TxtNombre { get; set; }
}
