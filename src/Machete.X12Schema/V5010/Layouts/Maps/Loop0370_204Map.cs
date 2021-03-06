namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0370_204Map :
        X12LayoutMap<Loop0370_204, X12Entity>
    {
        public Loop0370_204Map()
        {
            Id = "Loop_0370_204";
            Name = "Loop 0050";
            
            Segment(x => x.HazardousIdentificationInformation, 0);
            Segment(x => x.HazardousClassificationInformation, 1);
            Segment(x => x.HazardousMaterialShippingName, 2);
            Segment(x => x.FreeformHazardousMaterialInformation, 3);
            Segment(x => x.EPARequiredData, 4);
            Segment(x => x.CanadianDangerousRequirements, 5);
            Segment(x => x.TransborderDangerousRequirements, 6);
        }
    }
}