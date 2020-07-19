namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADT_A17 (Message) - 
    /// </summary>
    public interface ADT_A17 :
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
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }

        /// <summary>
        /// PV2
        /// </summary>
        Segment<PV2> PV2 { get; }

        /// <summary>
        /// DB1
        /// </summary>
        SegmentList<DB1> DB1 { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// PID2
        /// </summary>
        Segment<PID> PID2 { get; }

        /// <summary>
        /// PD12
        /// </summary>
        Segment<PD1> PD12 { get; }

        /// <summary>
        /// PV12
        /// </summary>
        Segment<PV1> PV12 { get; }

        /// <summary>
        /// PV22
        /// </summary>
        Segment<PV2> PV22 { get; }

        /// <summary>
        /// DB12
        /// </summary>
        SegmentList<DB1> DB12 { get; }

        /// <summary>
        /// OBX2
        /// </summary>
        SegmentList<OBX> OBX2 { get; }
    }
}