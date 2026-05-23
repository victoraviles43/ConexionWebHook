using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSolicitudesCxp
{
    public int IntIdSolicitdCxp { get; set; }

    public string? TxtSolicitante { get; set; }

    public int? IntIdUsuario { get; set; }

    public int? IntIdDepartamentos { get; set; }

    public int? IntIdPlaza { get; set; }

    public int? IntIdNegocio { get; set; }

    public int? IntIdTipoServicio { get; set; }

    public int? IntIdTipoGasto { get; set; }

    public string? TxtFolio { get; set; }

    public string? TxtConcepto { get; set; }

    public string? TxtRazonSocial { get; set; }

    public string? TxtBeneficiario { get; set; }

    public int? IntIdProveedor { get; set; }

    public string? TxtRfc { get; set; }

    public int? IntTipoPago { get; set; }

    public string? TxtRegistro { get; set; }

    public string? TxtDoctoSoporte { get; set; }

    public int? IntIdMoneda { get; set; }

    public decimal? DblImporte { get; set; }

    public decimal? DblIva { get; set; }

    public string? TxtImporteTexto { get; set; }

    public int? IntIdBanco { get; set; }

    public string? TxtClabe { get; set; }

    public string? TxtCuenta { get; set; }

    public string? TxtIban { get; set; }

    public DateTime? FecDia { get; set; }

    public DateTime? FecProxVencimiento { get; set; }

    public DateTime? FecPago { get; set; }

    public string? TxtComentarios { get; set; }

    public int? IntIdStatus { get; set; }

    public decimal? DblAlimentacion { get; set; }

    public decimal? DblTrasporte { get; set; }

    public int? IntIdEmpresaPg { get; set; }

    public int? IntIdRegCuenta { get; set; }

    public bool? BolCongelado { get; set; }

    public string? TxtMotivo { get; set; }

    public string? TxtRutaComprovante { get; set; }

    public string? TxtTarjeta { get; set; }

    public bool? BolPriodidad { get; set; }

    public bool? BolGastofijo { get; set; }

    public decimal? DblTipoCambio { get; set; }

    public int? IntIdEmpresa { get; set; }

    public int? IntIdCorporativo { get; set; }

    public int? IntIdGrupo { get; set; }

    public bool? BolGastoVariable { get; set; }

    public int? IntIdTipoServicioE { get; set; }

    public int? IntIdTipoGastoE { get; set; }

    public int? IntIdMotivo { get; set; }

    public int? IntIdTipoServicioUx { get; set; }

    public int? IntIdTipoGastoUx { get; set; }

    public int? IntIdTipoServicioM { get; set; }

    public int? IntIdTipoGastoM { get; set; }

    public int? IntIdTipoServicioS { get; set; }

    public int? IntIdTipoGastoS { get; set; }

    public int? IntIdTipoServicioZ { get; set; }

    public int? IntIdTipoGastoZ { get; set; }

    public decimal? DblTotalSolicitud { get; set; }
}
