using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class ViewGridActivosGeneral
{
    public int IntIdActivos { get; set; }

    public string? TxtUsuario { get; set; }

    public string? TxtNegocio { get; set; }

    public string? TxtPlaza { get; set; }

    public string? TxtDepartamento { get; set; }

    public string? TxtTipoActivo { get; set; }

    public string? TxtNombreActivo { get; set; }

    public string? TxtProveedor { get; set; }

    public string? TxtRfc { get; set; }

    public decimal? DblCantidad { get; set; }

    public string? TxtMoneda { get; set; }

    public decimal? DblMonto { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblTotal { get; set; }

    public decimal? Valor { get; set; }

    public decimal? ValorDep { get; set; }

    public DateOnly? FecDia { get; set; }

    public DateOnly? FecFactura { get; set; }

    public string? TxtFolio { get; set; }

    public string? TxtFactura { get; set; }

    public string? TxtRegistro { get; set; }

    public string? TxtStatusAct { get; set; }

    public DateOnly? FecBaja { get; set; }

    public string? TxtComentarios { get; set; }

    public string? TxtEmpresaPg { get; set; }

    public string? TxtCfdi { get; set; }

    public string? TxtMetPago { get; set; }

    public string? TxtForPago { get; set; }

    public string? TxtEstado { get; set; }

    public int? IntIdUnidad { get; set; }

    public string? TxtCalleNum { get; set; }

    public decimal? DbTipoCambio { get; set; }

    public string? TxtRfcExtranjero { get; set; }

    public string? TxtNumRegTri { get; set; }

    public string? TxtCuidad { get; set; }

    public string? TxtColonia { get; set; }

    public string? TxtCp { get; set; }

    public string? Modelo { get; set; }

    public string? Marca { get; set; }
}
