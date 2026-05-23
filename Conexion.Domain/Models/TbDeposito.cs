using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbDeposito
{
    public Guid LngIdDeposito { get; set; }

    public Guid? LngIdCliente { get; set; }

    public decimal? DblMonto { get; set; }

    public Guid? IntIdVia { get; set; }

    public Guid? IntIdBancoOp { get; set; }

    public string? TxtCuentaOp { get; set; }

    public Guid? IntIdBancoCli { get; set; }

    public string? TxtCuentaCli { get; set; }

    public string? TxtReferencia { get; set; }

    public bool? BolRealizarComp { get; set; }

    public bool? BolActivo { get; set; }

    public bool? BolCongelar { get; set; }

    public DateTime? FecRegistro { get; set; }

    public string? TxtOrigenRecurso { get; set; }
}
