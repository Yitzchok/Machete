namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLDT_1_860 :
        X12Layout
    {
        Segment<LDT> LeadTime { get; }
        
        SegmentList<QTY> QuantityInformation { get; }
        
        SegmentList<MTX> Text { get; }
        
        SegmentList<REF> ReferenceInformation { get; }
    }
}