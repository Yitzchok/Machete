// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFR_M06_MF_QUERY (Group) - 
    /// </summary>
    public interface MFR_M06_MF_QUERY :
        HL7V26Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// CM0
        /// </summary>
        Segment<CM0> CM0 { get; }

        /// <summary>
        /// MF_PHASE_SCHED_DETAIL
        /// </summary>
        LayoutList<MFR_M06_MF_PHASE_SCHED_DETAIL> MfPhaseSchedDetail { get; }
    }
}