// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LSU_U12 (MessageMap) - 
    /// </summary>
    public class LSU_U12Map :
        HL7V26LayoutMap<LSU_U12>
    {
        public LSU_U12Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EQU, 3, x => x.Required = true);
            Segment(x => x.EQP, 4, x => x.Required = true);
            Segment(x => x.ROL, 5);
        }
    }
}