﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2410_837PMap :
        X12LayoutMap<L2410_837P, X12Entity>
    {
        public L2410_837PMap()
        {
            Id = "2410";
            Name = "Drug Identification";
            
            Segment(x => x.DrugIdentification, 0);
            Segment(x => x.DrugQuantity, 1);
            Segment(x => x.PrescriptionOrCompoundDrugAssociationNumber, 2,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("VY") ||
                    p.ReferenceIdentificationQualifier.IsEqualTo("XZ")));
        }
    }
}