using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbAltaPrevencion05
{
    public Guid LngIdAltaPrevencion { get; set; }

    public Guid? LngIdCliente { get; set; }

    public bool? BolClienteExtranjero { get; set; }

    public decimal? PorProvedoresMax { get; set; }

    public decimal? PorProvedoresMin { get; set; }

    public bool? BolMateriaPrima { get; set; }

    public bool? BolProductosIntermedio { get; set; }

    public bool? BolProductosTerminados { get; set; }

    public bool? BolServicio { get; set; }

    public string? TxtTexto { get; set; }

    public bool? BolGrupoEmpresarial { get; set; }

    public bool? BolAccionista { get; set; }

    public bool? BolTercero { get; set; }

    public bool? BolExtranjero { get; set; }

    public bool? BolEntre15 { get; set; }

    public bool? BolEntre510 { get; set; }

    public bool? BolEntre1050 { get; set; }

    public bool? BolMas50 { get; set; }

    public decimal? PorVentaEfectivo { get; set; }

    public bool? BolTrasDinero { get; set; }

    public bool? BolInvertir { get; set; }

    public string? TxtFondoPrivado { get; set; }

    public bool? BolConocimiento { get; set; }

    public bool? BolLavadoDinero { get; set; }

    public bool? BolTrans2500 { get; set; }

    public bool? BolTrans32500 { get; set; }

    public bool? BolTrans55000 { get; set; }

    public bool? BolTrans1010000 { get; set; }

    public Guid? IntIdProductos { get; set; }

    public Guid? IntIdPais1 { get; set; }

    public Guid? IntIdPais2 { get; set; }

    public Guid? IntIdPais3 { get; set; }

    public Guid? IntIdPaisPer { get; set; }

    public string? TxtRazonSocialPer { get; set; }

    public Guid? IntIdPuestos { get; set; }

    public string? TxtNombreAcc { get; set; }

    public string? TxtRazonesAcc { get; set; }

    public string? TxtDomicilioAcc { get; set; }

    public string? TxtTransmisores { get; set; }

    public decimal? PorClienteEx { get; set; }

    public bool? BolMexicano { get; set; }

    public string? TxtNacionalidad { get; set; }

    public string? TxtActividadCom { get; set; }

    public Guid? IntIdGiro { get; set; }

    public string? TxtPuesto { get; set; }

    public bool? BolGrupoEmp { get; set; }

    public bool? BolRepresentacion { get; set; }

    public bool? BolFondoPropio { get; set; }

    public string? TxtFondoPropio { get; set; }

    public bool? BolConocimientoPf { get; set; }
}
