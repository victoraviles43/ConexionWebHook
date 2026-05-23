using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRutaSolicitud
{
    public int IntIdRutaSolicitud { get; set; }

    public int? IntIdSolicitdCxp { get; set; }

    public string? TxtRutaSolicitud { get; set; }

    public DateTime? FecRutaSolicitud { get; set; }

    public byte[]? ImgComprobante { get; set; }

    public byte[]? BinDocumento { get; set; }

    public string? TxtExtension { get; set; }

    public string? TxtNombre { get; set; }

    public int? IntIdStatusDoc { get; set; }
}
