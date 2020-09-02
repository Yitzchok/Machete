namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopR4_315Map :
        X12LayoutMap<LoopR4_315, X12Entity>
    {
        public LoopR4_315Map()
        {
            Id = "Loop_R4_315";
            Name = "Loop R4";
            
            Segment(x => x.PortOrTerminal, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}