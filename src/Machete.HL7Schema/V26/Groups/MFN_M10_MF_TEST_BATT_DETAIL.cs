// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M10_MF_TEST_BATT_DETAIL (Group) - 
    /// </summary>
    public interface MFN_M10_MF_TEST_BATT_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// OM5
        /// </summary>
        Segment<OM5> OM5 { get; }

        /// <summary>
        /// OM4
        /// </summary>
        SegmentList<OM4> OM4 { get; }
    }
}