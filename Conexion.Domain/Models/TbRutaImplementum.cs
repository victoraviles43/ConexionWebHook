using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRutaImplementum
{
    public int IntIdRutaImplementa { get; set; }

    public int? IntIdcliente { get; set; }

    public string? TxtRutaImplementa { get; set; }

    public DateTime? FecRutaImplementa { get; set; }

    public byte[]? ImgComprobante { get; set; }

    public byte[]? BinDocumento { get; set; }

    public string? TxtExtension { get; set; }

    public string? TxtNombre { get; set; }

    public int? IntIdStatusDoc { get; set; }

    public int? IntIdEmpresa { get; set; }
}
