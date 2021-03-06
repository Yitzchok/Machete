namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E04 (Message) - 
    /// </summary>
    public interface EHC_E04 :
        HL7V26Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// UAC
        /// </summary>
        SegmentList<UAC> UAC { get; }

        /// <summary>
        /// IVC
        /// </summary>
        Segment<IVC> IVC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PRODUCT_SERVICE_SECTION
        /// </summary>
        LayoutList<EHC_E04_PRODUCT_SERVICE_SECTION> ProductServiceSection { get; }
    }
}