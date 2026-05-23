using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbEntregaFlujoLog
{
    public int LngIdEntregaLog { get; set; }

    public int LngIdEntrega { get; set; }

    public int LngIdUsuario { get; set; }

    public DateTime FecMovimiento { get; set; }

    public int? LngIdFlujo { get; set; }

    public DateTime? FecFecha { get; set; }

    public int? IntIdCliente { get; set; }

    public string? TxtDireccion { get; set; }

    public string? TxtTelefono { get; set; }

    public decimal? DblValor { get; set; }

    public string? TxtValorLetra { get; set; }

    public string? TxtLugar { get; set; }

    public DateOnly? FecFechaPago { get; set; }

    public int? IntIdMoneda { get; set; }

    public decimal? DblTc { get; set; }

    public string? TxtNombreCli { get; set; }

    public string? TxtCliente { get; set; }

    public bool? BolCancelada { get; set; }

    public string? TxtComentarios { get; set; }

    public string? TxtMotivo { get; set; }

    public string? TxtTelefono2 { get; set; }

    public int? IntIdEmpresa { get; set; }
}
