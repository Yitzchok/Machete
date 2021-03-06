namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop0220_212 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }
        
        Segment<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        SegmentList<L11> BusinessInstructionsAndReferenceNumber { get; }
    }
}