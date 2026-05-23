using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbActivo
{
    public int IntIdActivos { get; set; }

    public string? TxtUsuario { get; set; }

    public int? IntIdNegocio { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdDepartamentos { get; set; }

    public int IntIdTipoActivo { get; set; }

    public string? TxtNombreActivo { get; set; }

    public string? TxtProveedor { get; set; }

    public string? TxtRfc { get; set; }

    public decimal? DblCantidad { get; set; }

    public int? IntIdMoneda { get; set; }

    public decimal? DblMonto { get; set; }

    public decimal? DblIva { get; set; }

    public decimal? DblTotal { get; set; }

    public string? TxtMontoLetra { get; set; }

    public DateOnly? FecDia { get; set; }

    public DateOnly? FecFactura { get; set; }

    public string? TxtFolio { get; set; }

    public string? TxtFactura { get; set; }

    public string? TxtRegistro { get; set; }

    public int? IntIdusuario { get; set; }

    public byte[]? ArImagen { get; set; }

    public int? IntIdStatusAct { get; set; }

    public DateOnly? FecBaja { get; set; }

    public string? TxtComentarios { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdCuentasPg { get; set; }

    public int? IntIdCfdi { get; set; }

    public int? IntIdMetPago { get; set; }

    public int? IntForPago { get; set; }

    public int? IntIdEstados { get; set; }

    public int? IntIdUnidad { get; set; }

    public string? TxtCalleNum { get; set; }

    public decimal? DbTipoCambio { get; set; }

    public string? TxtRfcExtranjero { get; set; }

    public string? TxtNumRegTri { get; set; }

    public string? TxtCuidad { get; set; }

    public string? TxtColonia { get; set; }

    public string? TxtCp { get; set; }

    public int? IntIdSolicitdCxp { get; set; }

    public string? TxtUsuarioUltimaModificacion { get; set; }

    public DateOnly? FecUltimaModificacion { get; set; }

    public string? TxtNumSerie { get; set; }
}
