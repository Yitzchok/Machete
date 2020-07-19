// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFR_M06_MF_PHASE_SCHED_DETAIL (GroupMap) - 
    /// </summary>
    public class MFR_M06_MF_PHASE_SCHED_DETAILMap :
        HL7V26LayoutMap<MFR_M06_MF_PHASE_SCHED_DETAIL>
    {
        public MFR_M06_MF_PHASE_SCHED_DETAILMap()
        {
            Segment(x => x.CM1, 0, x => x.Required = true);
            Segment(x => x.CM2, 1);
        }
    }
}