// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMG_O19_ORDER_PRIOR (Group) - 
    /// </summary>
    public interface OMG_O19_ORDER_PRIOR :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// TIMING_PRIOR
        /// </summary>
        LayoutList<OMG_O19_TIMING_PRIOR> TimingPrior { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// CTD
        /// </summary>
        Segment<CTD> CTD { get; }

        /// <summary>
        /// OBSERVATION_PRIOR
        /// </summary>
        LayoutList<OMG_O19_OBSERVATION_PRIOR> ObservationPrior { get; }
    }
}