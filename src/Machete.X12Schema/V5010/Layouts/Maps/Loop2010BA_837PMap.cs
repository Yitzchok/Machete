﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010BA_837PMap :
        X12LayoutMap<Loop2010BA_837P, X12Entity>
    {
        public Loop2010BA_837PMap()
        {
            Id = "2010BA";
            Name = "Subscriber Name";
            
            Segment(x => x.Subscriber, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("IL")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.DemographicInformation, 3);
            Segment(x => x.SecondaryIdentification, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("SY")));
            Segment(x => x.PropertyAndCasualtyClaimNumber, 5,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("Y4")));
            Segment(x => x.PropertyAndCasualtyContactInformation, 6);
        }
    }
}