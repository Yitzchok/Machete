﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2320_837P :
        X12Layout
    {
        Segment<SBR> SubscriberInformation { get; }
        
        SegmentList<CAS> ClaimLevelAdjustments { get; }
        
        Segment<AMT> CoordinationOfBenefitsPayerPaidAmount { get; }
        
        Segment<AMT> CoordinationOfBenefitsTotalNonCoveredAmount { get; }
        
        Segment<AMT> RemainingPatientLiability { get; }
        
        Segment<OI> InsuranceCoverageInformation { get; }
        
        Segment<MOA> OutpatientAdjudicationInformation { get; }
        
        Layout<L2330A_837P> Subscriber { get; }
        
        Layout<L2330B_837P> Payer { get; }
        
        LayoutList<L2330C_837P> PayerReferringProvider { get; }
        
        Layout<L2330D_837P> PayerRenderingProvider { get; }
        
        Layout<L2330E_837P> PayerServiceFacilityLocation { get; }
        
        Layout<L2330F_837P> PayerSupervisingProvider { get; }
        
        Layout<L2330G_837P> PayerBillingProvider { get; }
    }
}