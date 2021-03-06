﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2420H_837PMap :
        X12LayoutMap<Loop2420H_837P, X12Entity>
    {
        public Loop2420H_837PMap()
        {
            Id = "Loop_2420H_837P";
            Name = "Ambulance Drop Off Location";
                                    
            Segment(x => x.AmbulanceDropOffLocation, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("45")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
        }
    }
}