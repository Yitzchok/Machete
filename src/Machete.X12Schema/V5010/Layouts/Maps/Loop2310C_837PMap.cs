﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2310C_837PMap :
        X12LayoutMap<Loop2310C_837P, X12Entity>
    {
        public Loop2310C_837PMap()
        {
            Id = "2310C";
            Name = "Service Facility Location Name";
            
            Segment(x => x.ServiceFacilityLocation, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("77")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3);
            Segment(x => x.ContactInformation, 4);
        }
    }
}