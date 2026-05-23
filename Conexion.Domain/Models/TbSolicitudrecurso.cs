using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSolicitudrecurso
{
    public int LngIdSolicitudrecurso { get; set; }

    public decimal? DblValor { get; set; }

    public int? IntIdmoneda { get; set; }

    public DateOnly? FecInicio { get; set; }

    public DateOnly? FecVencimiento { get; set; }

    public int? IntIdEmpresa { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdPago { get; set; }

    public int? IntIdBanco { get; set; }

    public string? TxtCuenta { get; set; }

    public string? TxtClabe { get; set; }

    public int? IntIdStatusSol { get; set; }

    public string? TxtObservaciones { get; set; }

    public string? TxtRegistro { get; set; }

    public decimal? DblTc { get; set; }

    public string? TxtConcepto { get; set; }

    public int? IntIdusuario { get; set; }

    public int? IntIdTipoFin { get; set; }

    public int? IntIdStatusApro { get; set; }

    public int? IntIdUsuarioApro { get; set; }

    public bool? BolEnviado { get; set; }

    public string? TxtRechazo { get; set; }

    public int? IntIdEmpresaS { get; set; }
}
