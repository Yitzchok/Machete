// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPU_R25_PATIENT_OBSERVATION (GroupMap) - 
    /// </summary>
    public class OPU_R25_PATIENT_OBSERVATIONMap :
        HL7V26LayoutMap<OPU_R25_PATIENT_OBSERVATION>
    {
        public OPU_R25_PATIENT_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}