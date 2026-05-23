using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbIngCom
{
    public int LngIdIngCom { get; set; }

    public int? IntIdIngresos { get; set; }

    public int? IntIdComprovacion { get; set; }
}
