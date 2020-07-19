namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BPS_O29 (Message) - 
    /// </summary>
    public interface BPS_O29 :
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
        Segment<UAC> UAC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<BPS_O29_PATIENT> Patient { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<BPS_O29_ORDER> Order { get; }
    }
}