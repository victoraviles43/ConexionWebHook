using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbAltaPdv06
{
    public Guid LngIdAltaPdv { get; set; }

    public Guid? IntIdPosicion { get; set; }

    public Guid? IntIdGrado { get; set; }

    public Guid? IntIdConocimiento { get; set; }

    public bool? BolAcciones { get; set; }

    public bool? BolBonos { get; set; }

    public bool? BolEstructurado { get; set; }

    public bool? BolFondos { get; set; }

    public Guid? IntIdFondos { get; set; }

    public Guid? IntIdInversion { get; set; }

    public bool? BolEntre190 { get; set; }

    public bool? BolEntre32 { get; set; }

    public bool? BolMayor2 { get; set; }

    public decimal? PorEntre2 { get; set; }

    public decimal? PorMayor2 { get; set; }

    public Guid? IntIdEstrategia { get; set; }

    public Guid? IntIdSeguridad { get; set; }

    public Guid? IntIdMercado { get; set; }

    public Guid? IntIdCompraAcc { get; set; }

    public Guid? IntIdReaccion { get; set; }

    public Guid? IntIdPorcentaje { get; set; }

    public Guid? IntIdMovimientos { get; set; }

    public Guid? IntIdMontoEstimado { get; set; }

    public Guid? IntIdFormaMensual { get; set; }

    public Guid? IntIdRiesgo { get; set; }

    public Guid? IntIdIntitucciones { get; set; }

    public Guid? LngIdCliente { get; set; }

    public bool? BolActiva { get; set; }

    public Guid? IngIdPosicion { get; set; }

    public string? TxtOtroFondo { get; set; }

    public decimal? BolEntre1 { get; set; }

    public Guid? IntIdPosicionPdv { get; set; }

    public string? TxtPosicionPdv { get; set; }

    public bool? BolCongelar { get; set; }
}
