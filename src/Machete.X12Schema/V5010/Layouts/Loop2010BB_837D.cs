﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2010BB_837D :
        X12Layout
    {
        Segment<NM1> Payer { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
        
        Segment<REF> BillingProviderSecondaryIdentification { get; }
    }
}