﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2330F_837DMap :
        X12LayoutMap<Loop2330F_837D, X12Entity>
    {
        public Loop2330F_837DMap()
        {
            Id = "2330F";
            Name = "Other Payer Billing Provider";
            
            Segment(x => x.OtherPayerBillingProvider, 0);
            Segment(x => x.SecondaryIdentification, 1,
                x => x.IsRequired().Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("G2") ||
                                                                            p.ReferenceIdentificationQualifier.IsEqualTo("LU")));
        }
    }
}