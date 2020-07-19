﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2010BA_837IMap :
        X12LayoutMap<L2010BA_837I, X12Entity>
    {
        public L2010BA_837IMap()
        {
            Id = "2010BA";
            Name = "Subscriber Name";
            
            Segment(x => x.Name, 0,
                x => x.Condition = parser => parser.Where(p => p.EntityIdentifierCode.IsEqualTo("IL")));
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.DemographicInformation, 3);
            Segment(x => x.SecondaryIdentification, 4,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("SY")));
            Segment(x => x.PropertyAndCasualtyClaimNumber, 5,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("Y4")));
        }
    }
}