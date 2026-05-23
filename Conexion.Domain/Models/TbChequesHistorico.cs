using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbChequesHistorico
{
    public int LngIdChequesHistorico { get; set; }

    public int? LngIdCheques { get; set; }

    public int? LngIdCuentaCheque { get; set; }

    public string? TxtNombreSolicitante { get; set; }

    public string? TxtPlaza { get; set; }

    public string? TxtUnidadNegocio { get; set; }

    public string? TxtRazonSocial { get; set; }

    public DateTime? FecSolicitud { get; set; }

    public string? TxtRegistroRequisicion { get; set; }

    public string? TxtNumCuenta { get; set; }

    public string? TxtInstruccionPago { get; set; }

    public int? IntIdBanco { get; set; }

    public decimal? DblValor { get; set; }

    public DateTime? FecEnvio { get; set; }

    public int? IntIdStatusCheque { get; set; }

    public string? TxtConcepto { get; set; }

    public DateTime? FecDia { get; set; }

    public string? TxtUsuario { get; set; }
}
