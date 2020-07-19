namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// DFT_P11 (Message) - 
    /// </summary>
    public interface DFT_P11 :
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
        /// EVN
        /// </summary>
        Segment<EVN> EVN { get; }

        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PD1
        /// </summary>
        Segment<PD1> PD1 { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }

        /// <summary>
        /// PV2
        /// </summary>
        Segment<PV2> PV2 { get; }

        /// <summary>
        /// ROL2
        /// </summary>
        SegmentList<ROL> ROL2 { get; }

        /// <summary>
        /// DB1
        /// </summary>
        SegmentList<DB1> DB1 { get; }

        /// <summary>
        /// COMMON_ORDER
        /// </summary>
        LayoutList<DFT_P11_COMMON_ORDER> CommonOrder { get; }

        /// <summary>
        /// DG1
        /// </summary>
        SegmentList<DG1> DG1 { get; }

        /// <summary>
        /// DRG
        /// </summary>
        Segment<DRG> DRG { get; }

        /// <summary>
        /// GT1
        /// </summary>
        SegmentList<GT1> GT1 { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        LayoutList<DFT_P11_INSURANCE> Insurance { get; }

        /// <summary>
        /// ACC
        /// </summary>
        Segment<ACC> ACC { get; }

        /// <summary>
        /// FINANCIAL
        /// </summary>
        LayoutList<DFT_P11_FINANCIAL> Financial { get; }
    }
}