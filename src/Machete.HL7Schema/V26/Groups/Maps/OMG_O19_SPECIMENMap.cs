// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMG_O19_SPECIMEN (GroupMap) - 
    /// </summary>
    public class OMG_O19_SPECIMENMap :
        HL7V26LayoutMap<OMG_O19_SPECIMEN>
    {
        public OMG_O19_SPECIMENMap()
        {
            Segment(x => x.SPM, 0, x => x.Required = true);
            Segment(x => x.OBX, 1);
            Layout(x => x.Container, 2);
        }
    }
}