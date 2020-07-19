// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BAR_P05_INSURANCE (Group) - 
    /// </summary>
    public interface BAR_P05_INSURANCE :
        HL7V26Layout
    {
        /// <summary>
        /// IN1
        /// </summary>
        Segment<IN1> IN1 { get; }

        /// <summary>
        /// IN2
        /// </summary>
        Segment<IN2> IN2 { get; }

        /// <summary>
        /// IN3
        /// </summary>
        SegmentList<IN3> IN3 { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }
    }
}