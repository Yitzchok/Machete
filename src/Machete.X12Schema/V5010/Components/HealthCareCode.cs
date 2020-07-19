﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface HealthcareCode :
        X12Component
    {
        Value<string> DiagnosisTypeCode { get; }
        
        Value<string> DiagnosisCode { get; }
        
        Value<string> DateTimePeriodFormatQualifier { get; }
        
        Value<DateTimePeriod> DateTimePeriod { get; }
        
        Value<decimal> MonetaryAmount { get; }
        
        Value<decimal> Quantity { get; }
        
        Value<string> VersionIdentifier { get; }
        
        Value<string> IndustryCode { get; }
        
        Value<string> ResponseCode { get; }
    }
}