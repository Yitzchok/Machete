// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OUL_R22_SPECIMEN (Group) - 
    /// </summary>
    public interface OUL_R22_SPECIMEN :
        HL7V26Layout
    {
        /// <summary>
        /// SPM
        /// </summary>
        Segment<SPM> SPM { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// CONTAINER
        /// </summary>
        LayoutList<OUL_R22_CONTAINER> Container { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<OUL_R22_ORDER> Order { get; }
    }
}