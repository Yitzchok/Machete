namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopACK_855 :
        X12Layout
    {
        Segment<ACK> LineItemAcknowledgement { get; }
        
        Segment<DTM> DateOrTimeReference { get; }
    }
}