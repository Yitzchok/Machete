// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R24_RESULT (GroupMap) - 
    /// </summary>
    public class OUL_R24_RESULTMap :
        HL7V26LayoutMap<OUL_R24_RESULT>
    {
        public OUL_R24_RESULTMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.TCD, 1);
            Segment(x => x.SID, 2);
            Segment(x => x.NTE, 3);
        }
    }
}