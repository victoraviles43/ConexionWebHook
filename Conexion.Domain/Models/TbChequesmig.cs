using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbChequesmig
{
    public int LngIdCheques { get; set; }

    public int? LngIdCuentaCheque { get; set; }

    public decimal? NumFolio { get; set; }

    public DateTime? FecDia { get; set; }

    public int? IntIdBanco { get; set; }

    public DateOnly? FecCheque { get; set; }

    public DateOnly? FecCompensacion { get; set; }

    public DateOnly? FecEnvio { get; set; }

    public string? TxtEmisor { get; set; }

    public int? IntIdStatusCheque { get; set; }

    public string? TxtBeneficiario { get; set; }

    public string? TxtDescripcion { get; set; }

    public byte[]? ImgCheque { get; set; }

    public decimal? DblValor { get; set; }

    public int? IntIdPlaza { get; set; }

    public string? TxtResponsable { get; set; }

    public string? TxtSolicitante { get; set; }

    public string? TxtMotivo { get; set; }
}
