using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDepositosTe
{
    public int LngIdDepositosTes { get; set; }

    public int? LngIdDepositos { get; set; }

    public int? IntIdStatusTes { get; set; }

    public string? TxtRutaTes { get; set; }

    public DateTime? FecDepositoTes { get; set; }

    public byte[]? ImgComprobante { get; set; }

    public string? TxtExtension { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtRegistro { get; set; }
}
