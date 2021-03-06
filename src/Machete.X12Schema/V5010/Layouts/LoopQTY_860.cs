namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopQTY_860 :
        X12Layout
    {
        Segment<QTY> QuantityInformation { get; }
        
        SegmentList<SI> ServiceCharacteristicIdentification { get; }
    }
}