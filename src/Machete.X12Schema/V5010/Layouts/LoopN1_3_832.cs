namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopN1_3_832 :
        X12Layout
    {
        Segment<N1> PartyIdentification { get; }
        
        SegmentList<N2> AdditionalNameInformation { get; }
        
        SegmentList<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        SegmentList<REF> ReferenceIdentification { get; }
        
        SegmentList<PER> AdministrativeCommunicationsContact { get; }
        
        SegmentList<DTM> DateOrTimeReference { get; }
        
        SegmentList<MTX> Text { get; }
        
        SegmentList<PKG> MarkingPackagingOrLoading { get; }
        
        SegmentList<PAL> PalletTypeAndLoadCharacteristics { get; }
        
        Segment<SPI> SpecificationIdentifier { get; }
    }
}