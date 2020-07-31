namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopLM_870 :
        X12Layout
    {
        Segment<LM> CodeSourceInformation { get; }
        
        SegmentList<LQ> IndustryCodeIdentification { get; }
    }
}