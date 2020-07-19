// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z82_TREATMENT (Group) - 
    /// </summary>
    public interface RSP_Z82_TREATMENT :
        HL7V26Layout
    {
        /// <summary>
        /// RXC
        /// </summary>
        SegmentList<RXC> RXC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}