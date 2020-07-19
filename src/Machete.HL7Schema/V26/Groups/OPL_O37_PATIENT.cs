// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPL_O37_PATIENT (Group) - 
    /// </summary>
    public interface OPL_O37_PATIENT :
        HL7V26Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PD1
        /// </summary>
        Segment<PD1> PD1 { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// INSURANCE
        /// </summary>
        LayoutList<OPL_O37_INSURANCE> Insurance { get; }

        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }
    }
}