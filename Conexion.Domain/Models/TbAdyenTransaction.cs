using System;
using System.Collections.Generic;

namespace Conexion.Domain.Models;

public partial class TbAdyenTransaction
{
    public int LngIdTransaction { get; set; }

    public string? TxtCompanyAccount { get; set; }

    public string? TxtMerchantAccount { get; set; }

    public string? TxtPspReference { get; set; }

    public string? TxtBalancePlatformCredit { get; set; }

    public string? TxtPaymentMethod { get; set; }

    public DateTime? FecCreationDate { get; set; }

    public string? TxtTimeZone { get; set; }

    public string? TxtType { get; set; }

    public string? TxtReserved5 { get; set; }

    public string? TxtReserved8 { get; set; }

    public string? TxtReserved9 { get; set; }

    public string? TxtSettlementFlow { get; set; }

    public string? TxtReserved7 { get; set; }

    public string? TxtShopperCountry { get; set; }

    public string? TxtAuthorisedDateTimeZone { get; set; }

    public string? TxtAdvancementCode { get; set; }

    public string? TxtAdvancementBatch { get; set; }

    public string? TxtIssuerCountry { get; set; }

    public string? TxtReserved6 { get; set; }

    public string? TxtShopperReference { get; set; }

    public string? TxtTenderReference { get; set; }

    public string? TxtStore { get; set; }

    public string? TxtPaymentMethodVariant { get; set; }

    public string? TxtPosTransactionDateTimeZone { get; set; }

    public string? TxtArn { get; set; }

    public string? TxtMerchantOrderReference { get; set; }

    public string? TxtFundsDestination { get; set; }

    public string? TxtDisputeReference { get; set; }

    public string? TxtClearingNetwork { get; set; }

    public string? TxtModificationReference { get; set; }

    public string? TxtBalancePlatformDebit { get; set; }

    public string? TxtReserved1 { get; set; }

    public string? TxtCardNumber { get; set; }

    public DateTime? FecPosTransactionDate { get; set; }

    public string? TxtAcquirer { get; set; }

    public string? TxtAdditionalType { get; set; }

    public string? TxtGlobalCardBrand { get; set; }

    public string? TxtBalanceCurrency { get; set; }

    public string? TxtMetadata { get; set; }

    public string? TxtBookingDateTimeZone { get; set; }

    public string? TxtBookingType { get; set; }

    public string? TxtGrossCurrency { get; set; }

    public string? TxtInstallments { get; set; }

    public string? TxtModificationMerchantReference { get; set; }

    public string? TxtNetCurrency { get; set; }

    public string? TxtPaymentTransactionGroup { get; set; }

    public string? TxtRegisterBookingType { get; set; }

    public string? TxtReserved10 { get; set; }

    public string? TxtReserved2 { get; set; }

    public string? TxtReserved3 { get; set; }

    public string? TxtReserved4 { get; set; }

    public string? TxtSplitSettlement { get; set; }

    public string? TxtSplitPaymentData { get; set; }

    public string? TxtTerminalId { get; set; }

    public decimal? DblAdvancedNc { get; set; }

    public decimal? DblAuthorisationCode { get; set; }

    public decimal? DblBatchNumber { get; set; }

    public decimal? DblCommissionNc { get; set; }

    public decimal? DblDccmarkupNc { get; set; }

    public decimal? DblExchangeRate { get; set; }

    public decimal? DblGratuityAmount { get; set; }

    public decimal? DblGrossCreditGc { get; set; }

    public decimal? DblGrossDebitGc { get; set; }

    public decimal? DblGrossFeesNc { get; set; }

    public decimal? DblInterchangeNc { get; set; }

    public decimal? DblMarkupNc { get; set; }

    public decimal? DblNetCreditBc { get; set; }

    public decimal? DblNetCreditNc { get; set; }

    public decimal? DblNetDebitBc { get; set; }

    public decimal? DblNetDebitNc { get; set; }

    public decimal? DblPaymentFeesNc { get; set; }

    public decimal? DblSchemeFeesNc { get; set; }

    public decimal? DblSurchargeAmount { get; set; }

    public DateTime? FecAuthorisedDate { get; set; }

    public DateTime? FecBookingDate { get; set; }

    public DateTime? FecBookingDateAms { get; set; }

    public DateTime? FecCreationDateAms { get; set; }

    public string? TxtMerchantReference { get; set; }

    public string? TxtAdditiolType { get; set; }

    public string? TxtTermilId { get; set; }

    public string? TxtFundsDestition { get; set; }
}
