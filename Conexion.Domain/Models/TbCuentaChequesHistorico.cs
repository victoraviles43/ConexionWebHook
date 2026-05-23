using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCuentaChequesHistorico
{
    public int LngIdCuentaChequeHistorico { get; set; }

    public int? LngIdCuentaCheque { get; set; }

    public string? TxtNombreCuenta { get; set; }

    public string? TxtRegistro { get; set; }

    public string? NumCuenta { get; set; }

    public string? NumClabe { get; set; }

    public int? IntIdBanco { get; set; }

    public int? IntIdMoneda { get; set; }

    public int? NumFolioIni { get; set; }

    public int? NumFolioFin { get; set; }

    public DateTime? FecDia { get; set; }

    public bool? BolActivo { get; set; }

    public DateTime? FecFechaCuenta { get; set; }

    public string? TxtObservaciones { get; set; }

    public string? TxtSolicitante { get; set; }
}
