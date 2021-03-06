namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopPKG_850 :
        X12Layout
    {
        Segment<PKG> MarkingPackagingOrLoading { get; }
        
        SegmentList<MEA> Measurements { get; }
    }
}