using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEntregaFlujoHistoricoSe
{
    public int LngEntregaFlujoHistoricoSe { get; set; }

    public int LngIdEntregaFlujo { get; set; }

    public DateTime? FecFecha { get; set; }

    public int? IntIdUnidadNegocio { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtTelefono { get; set; }

    public decimal? DblValor { get; set; }

    public string? TxtValorLetra { get; set; }

    public string? TxtLugar { get; set; }

    public DateTime? FecFechaPago { get; set; }

    public int? IntIdMoneda { get; set; }

    public decimal? DblTc { get; set; }

    public string? TxtNombreCli { get; set; }

    public int? IntIdUsuario { get; set; }

    public bool? BolCancelada { get; set; }

    public string? TxtComentarios { get; set; }

    public string? TxtMotivo { get; set; }

    public string? TxtTelefono2 { get; set; }

    public string? TxtFolio { get; set; }

    public int? IntIdEstatus { get; set; }

    public string? TxtFolioSeguimiento { get; set; }

    public string? TxtReferencias { get; set; }

    public DateTime? FecEntrega { get; set; }

    public decimal? DblComision { get; set; }
}
