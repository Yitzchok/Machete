﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2420B_837DMap :
        X12LayoutMap<Loop2420B_837D, X12Entity>
    {
        public Loop2420B_837DMap()
        {
            Id = "2420B";
            Name = "Assistant Surgeon Name";
            
            Segment(x => x.AssistantSurgeon, 0);
            Segment(x => x.SpecialtyInformation, 1);
            Segment(x => x.SecondaryIdentification, 2,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("0B") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("1G") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                               p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}