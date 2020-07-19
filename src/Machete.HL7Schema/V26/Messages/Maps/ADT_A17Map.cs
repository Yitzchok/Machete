// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A17 (MessageMap) - 
    /// </summary>
    public class ADT_A17Map :
        HL7V26LayoutMap<ADT_A17>
    {
        public ADT_A17Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PD1, 5);
            Segment(x => x.PV1, 6, x => x.Required = true);
            Segment(x => x.PV2, 7);
            Segment(x => x.DB1, 8);
            Segment(x => x.OBX, 9);
            Segment(x => x.PID2, 10, x => x.Required = true);
            Segment(x => x.PD12, 11);
            Segment(x => x.PV12, 12, x => x.Required = true);
            Segment(x => x.PV22, 13);
            Segment(x => x.DB12, 14);
            Segment(x => x.OBX2, 15);
        }
    }
}