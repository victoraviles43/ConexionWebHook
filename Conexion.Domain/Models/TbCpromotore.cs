using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbCpromotore
{
    public int LngIdPromotor { get; set; }

    public string? TxtUsuario { get; set; }

    public DateOnly? FecDia { get; set; }

    public string? TxtNombre { get; set; }

    public string? TxtApaterno { get; set; }

    public string? TxtAmaterno { get; set; }

    public int? IntIdSexo { get; set; }

    public string? TxtRfc { get; set; }

    public string? NumCodigoPostal { get; set; }

    public string? TxtRegimenFiscal { get; set; }

    public string? TxtNacionalidad { get; set; }

    public int? IntIdClasificacion { get; set; }

    public int? IntIdMetodo { get; set; }

    public int? IntIdMoneda { get; set; }

    public int? IntIdCalculo { get; set; }

    public int? IntIdPeriodicidad { get; set; }

    public decimal? DblAsimilados { get; set; }

    public decimal? DblSindicato { get; set; }

    public decimal? DblStp { get; set; }

    public decimal? DblPterceros { get; set; }

    public decimal? DblEfectivo { get; set; }

    public decimal? DblCostoMayoreo { get; set; }

    public string? TxtFolio { get; set; }

    public bool? BolActivo { get; set; }
}
