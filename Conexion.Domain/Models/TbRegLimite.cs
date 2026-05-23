using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbRegLimite
{
    public int IntIdRegLimite { get; set; }

    public int? IntIdSolicitdCxp { get; set; }

    public int? IntIdTablaLimite { get; set; }

    public decimal? DblLimiteInf { get; set; }

    public decimal? DblLimiteSup { get; set; }

    public int? IntIdSubarea { get; set; }

    public bool? BolBloqueado { get; set; }

    public int? IntIdusuario { get; set; }
}
