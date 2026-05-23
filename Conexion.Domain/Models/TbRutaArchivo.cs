using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRutaArchivo
{
    public int IntIdRutaArchivo { get; set; }

    public int? LngIdflujo { get; set; }

    public string? TxtRutaArchivo { get; set; }

    public DateTime? FecRutaArchivo { get; set; }

    public byte[]? ImgComprobante { get; set; }

    public byte[]? BinDocumento { get; set; }

    public string? TxtExtension { get; set; }

    public string? TxtNombre { get; set; }

    public int? IntIdStatusDoc { get; set; }

    public string? TxtComentarios { get; set; }
}
