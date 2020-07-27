namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLDT_2_860Map :
        X12LayoutMap<LoopLDT_2_860, X12Entity>
    {
        public LoopLDT_2_860Map()
        {
            Id = "Loop_LDT_2_860";
            Name = "Loop LDT";
            
            Segment(x => x.LeadTime, 0);
            Segment(x => x.Quantity, 1);
            Segment(x => x.Text, 2);
            Segment(x => x.ReferenceInformation, 3);
            Layout(x => x.LoopLM, 4);
        }
    }
}