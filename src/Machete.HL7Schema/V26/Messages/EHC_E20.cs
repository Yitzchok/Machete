namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E20 (Message) - 
    /// </summary>
    public interface EHC_E20 :
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
        /// CTD
        /// </summary>
        SegmentList<CTD> CTD { get; }

        /// <summary>
        /// LOC
        /// </summary>
        SegmentList<LOC> LOC { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// PAT_INFO
        /// </summary>
        LayoutList<EHC_E20_PAT_INFO> PatInfo { get; }

        /// <summary>
        /// PSL_ITEM_INFO
        /// </summary>
        LayoutList<EHC_E20_PSL_ITEM_INFO> PslItemInfo { get; }
    }
}