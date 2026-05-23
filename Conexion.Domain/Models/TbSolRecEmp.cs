using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbSolRecEmp
{
    public int LngSolRecEmp { get; set; }

    public int? LngIdSolicitudrecurso { get; set; }

    public int? IntIdEmpresa { get; set; }
}
