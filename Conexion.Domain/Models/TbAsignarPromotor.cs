using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbAsignarPromotor
{
    public int LngIdApromotor { get; set; }

    public int LngIdPromotor { get; set; }

    public int? IntIdSucursal { get; set; }

    public int? IntIdEvento { get; set; }

    public int? IntIdClasificacion { get; set; }

    public int? IntIdMetodo { get; set; }

    public int? IntIdMoneda { get; set; }

    public bool? BolSocio { get; set; }

    public bool? BolAntes { get; set; }

    public bool? BolPromotor { get; set; }

    public decimal? DblSocio { get; set; }

    public decimal? DblAntes { get; set; }

    public decimal? DblPromotor { get; set; }

    public bool? BolActivo { get; set; }

    public DateOnly? FecInicio { get; set; }
}
