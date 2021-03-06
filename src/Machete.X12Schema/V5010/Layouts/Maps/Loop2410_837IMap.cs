﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2410_837IMap :
        X12LayoutMap<Loop2410_837I, X12Entity>
    {
        public Loop2410_837IMap()
        {
            Id = "Loop_2410_837I";
            Name = "Drug Identification";
            
            Segment(x => x.DrugIdentification, 0);
            Segment(x => x.DrugQuantity, 1);
            Segment(x => x.PrescriptionOrCompoundDrugAssociationNumber, 2,
                x => x.Condition = parser => parser.Where(p => p.ReferenceIdentificationQualifier.IsEqualTo("VY")
                                                               || p.ReferenceIdentificationQualifier.IsEqualTo("XZ")));
        }
    }
}