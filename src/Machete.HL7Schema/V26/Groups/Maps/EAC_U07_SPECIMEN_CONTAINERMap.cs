// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EAC_U07_SPECIMEN_CONTAINER (GroupMap) - 
    /// </summary>
    public class EAC_U07_SPECIMEN_CONTAINERMap :
        HL7V26LayoutMap<EAC_U07_SPECIMEN_CONTAINER>
    {
        public EAC_U07_SPECIMEN_CONTAINERMap()
        {
            Segment(x => x.SAC, 0, x => x.Required = true);
            Segment(x => x.SPM, 1);
        }
    }
}