using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbLineasTelefonica
{
    public int LngIdLineaTelefonica { get; set; }

    public int? IntIdEstatusAsignacion { get; set; }

    public string? TxtLinea { get; set; }

    public string? TxtCompaniaTelefonica { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdNegocio { get; set; }

    public string? TxtCuenta { get; set; }

    public DateTime? FecInicioContrato { get; set; }

    public DateTime? FecFinContrato { get; set; }

    public decimal? DblPlazo { get; set; }

    public string? TxtPlanMovil { get; set; }

    public decimal? DblCosto { get; set; }

    public int? IntIdOficina { get; set; }

    public string? TxtObservaciones { get; set; }

    public DateTime? FecInicio { get; set; }
}
