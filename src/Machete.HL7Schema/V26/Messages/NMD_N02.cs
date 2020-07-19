// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMD_N02 (Message) - 
    /// </summary>
    public interface NMD_N02 :
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
        /// CLOCK_AND_STATS_WITH_NOTES
        /// </summary>
        LayoutList<NMD_N02_CLOCK_AND_STATS_WITH_NOTES> ClockAndStatsWithNotes { get; }
    }
}