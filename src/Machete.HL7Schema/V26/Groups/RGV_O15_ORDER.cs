// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RGV_O15_ORDER (Group) - 
    /// </summary>
    public interface RGV_O15_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<RGV_O15_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Layout<RGV_O15_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// ENCODING
        /// </summary>
        Layout<RGV_O15_ENCODING> Encoding { get; }

        /// <summary>
        /// GIVE
        /// </summary>
        LayoutList<RGV_O15_GIVE> Give { get; }
    }
}