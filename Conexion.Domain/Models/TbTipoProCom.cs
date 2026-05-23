using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbTipoProCom
{
    public Guid LngIdTipoProCom { get; set; }

    public Guid? LngIdAltaPrevencion { get; set; }

    public Guid? IntIdTipoProCom { get; set; }
}
