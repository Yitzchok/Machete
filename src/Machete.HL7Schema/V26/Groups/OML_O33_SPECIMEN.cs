// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OML_O33_SPECIMEN (Group) - 
    /// </summary>
    public interface OML_O33_SPECIMEN :
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
        /// SAC
        /// </summary>
        SegmentList<SAC> SAC { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<OML_O33_ORDER> Order { get; }
    }
}