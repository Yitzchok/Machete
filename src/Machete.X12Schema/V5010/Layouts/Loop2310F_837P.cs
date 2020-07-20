﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2310F_837P :
        X12Layout
    {
        Segment<NM1> AmbulanceDropOffLocation { get; }
        
        Segment<N3> Address { get; }
        
        Segment<N4> GeographicInformation { get; }
    }
}