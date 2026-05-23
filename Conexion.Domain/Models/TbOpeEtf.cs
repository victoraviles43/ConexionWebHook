using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbOpeEtf
{
    public Guid LngIdOpeEtfs { get; set; }

    public Guid? LngIdGeneral { get; set; }

    public decimal? PorComision { get; set; }

    public string? TxtCapCompro { get; set; }

    public decimal? DecImporteComision { get; set; }

    public int? IntValSecFee { get; set; }

    public decimal? IntValImporteSecFee { get; set; }

    public decimal? DecImporteIva { get; set; }

    public bool? BolMercadoPrimario { get; set; }

    public decimal? DecImporteNeto { get; set; }

    public bool? BolCongelar { get; set; }
}
