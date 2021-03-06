namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EAN_U09 (Message) - 
    /// </summary>
    public interface EAN_U09 :
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
        /// EQU
        /// </summary>
        Segment<EQU> EQU { get; }

        /// <summary>
        /// NOTIFICATION
        /// </summary>
        LayoutList<EAN_U09_NOTIFICATION> Notification { get; }

        /// <summary>
        /// ROL
        /// </summary>
        Segment<ROL> ROL { get; }
    }
}