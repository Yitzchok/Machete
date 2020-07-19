// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z82_ORDER_DETAIL (Group) - 
    /// </summary>
    public interface RSP_Z82_ORDER_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// RXO
        /// </summary>
        Segment<RXO> RXO { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }

        /// <summary>
        /// TREATMENT
        /// </summary>
        Layout<RSP_Z82_TREATMENT> Treatment { get; }
    }
}