using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbAltaEmpresa02
{
    public Guid LngIdAltaEmpresa { get; set; }

    public Guid? LngIdCliente { get; set; }

    public Guid? LngIdDocumento { get; set; }

    public string? TxtDocumento { get; set; }

    public DateOnly? FecDocumento { get; set; }

    public Guid? IntIdEstado { get; set; }

    public string TxtLugar { get; set; } = null!;

    public string? TxtNombre { get; set; }

    public string? TxtDescripcion { get; set; }

    public string? TxtNombreRepres { get; set; }

    public string? TxtApellidoPaterno { get; set; }

    public string? TxtApellidoMaterno { get; set; }

    public string? TxtPoderP { get; set; }

    public string? TxtEscrituraPno { get; set; }

    public DateOnly? FecEscritura { get; set; }

    public string? TxtOtorgadaLic { get; set; }

    public string? TxtNotariaNo { get; set; }

    public Guid? IntIdEntidadFederativa { get; set; }

    public string? TxtRegistroPublico { get; set; }

    public bool? BolInstitucional { get; set; }

    public bool? BolSofisticado { get; set; }

    public bool? BolCongelar { get; set; }
}
