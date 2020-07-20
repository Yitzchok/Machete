﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2310D_837D :
        X12Layout
    {
        Segment<NM1> AssistantSurgeon { get; }
        
        Segment<PRV> SpecialtyInformation { get; }
        
        SegmentList<REF> SecondaryIdentification { get; }
    }
}