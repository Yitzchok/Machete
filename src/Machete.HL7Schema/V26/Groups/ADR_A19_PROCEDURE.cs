// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ADR_A19_PROCEDURE (Group) - 
    /// </summary>
    public interface ADR_A19_PROCEDURE :
        HL7V26Layout
    {
        /// <summary>
        /// PR1
        /// </summary>
        Segment<PR1> PR1 { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }
    }
}